using BIAI.Data;
using BIAI.Interface.Columns;
using BIAI.Interface.Logging;
using BIAI.Network;
using BIAI.Network.Events;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;

namespace BIAI.Interface.Network
{
    public class NeuralNetworkService
    {
        private const string BELT = "--------------";

        public event EventHandler<ProcessResult> TrainingCompleted;
        public event EventHandler<ProcessResult> PredictionCompleted;

        private NeuralNetwork network;
        private Logger trainingLogger;
        private Logger predictionLogger;
        private Limits[] outputIntervals;
        private List<InputInitializer> initializers;
        private double learningRate;
        private double learningDataRatio;
        private double weightDecay;
        private double momentum;
        private int epochs;
        private int? rowLimit;

        public IReadOnlyList<ColumnSetting> Columns { get; }

        public NeuralNetworkService(IEnumerable<ColumnSetting> columnSettings, Logger trainingLogger, Logger predictingLogger, 
            IEnumerable<Limits> outputIntervals, double learningRate, double learningDataRatio, double weightDecay, double momentum,
            int epochs, int hiddenNeurons, int? rowLimit)
        {
            this.outputIntervals = outputIntervals.ToArray();
            Columns = columnSettings.Where(x => x.Selected).ToList();
            network = new NeuralNetwork(Columns.Count, hiddenNeurons, this.outputIntervals.Length);
            this.trainingLogger = trainingLogger;
            this.predictionLogger = predictingLogger;
            this.learningRate = learningRate;
            this.learningDataRatio = learningDataRatio;
            this.epochs = epochs;
            this.rowLimit = rowLimit;
            this.weightDecay = weightDecay;
            this.momentum = momentum;

            network.TrainingEpochCompleted += OnTrainingEpochComplete;
        }

        public void Start()
        {
            var dataSets = new List<TrainingDataSet>();

            trainingLogger.Message($"{BELT}{DateTime.Now.TimeOfDay}{BELT}");
            trainingLogger.Message("Opening connection to database");
            using (var db = new GlobalTerrorismContext())
            {
                var sampleRecord = db.AttackRecords.First(); // assert database connection

                trainingLogger.Message("Preparing");

                var count = db.AttackRecords.Count();
                var nulls = 0;

                initializers = Columns.Select(x => new InputInitializer(x.PropertyInfo)).ToList();

                trainingLogger.Message("Downloading data");
                var rnd = new Random().NextDouble();
                var attackRecords = db.AttackRecords.OrderBy(x => SqlFunctions.Checksum(x.Id * rnd)).ThenBy(x => x.Id).ToList();

                trainingLogger.Message("Normalizing data");
                for (int i = 0; i < count; i++)
                {
                    foreach (var initializer in initializers)
                    {
                        initializer.UpdateLimits(attackRecords[i]);
                    }
                }

                trainingLogger.Message("Creating data sets");
                
                for (int i = 0; i < count; i++)
                {
                    var inputs = initializers.Select(x => x.TryGetValue(attackRecords[i]));
                    if (inputs.Any(x => x == null))
                    {
                        nulls++;
                        continue;
                    }

                    var dataSet = new TrainingDataSet
                    {
                        Inputs = inputs.Select(x => x.Value).ToArray(),
                        Outputs = CreateOutput(attackRecords[i].Fatalities)
                    };

                    dataSets.Add(dataSet);
                    if (rowLimit.HasValue && dataSets.Count == rowLimit)
                        break;
                }
                
                trainingLogger.Message($"{nulls} records skipped as they contained nulls");
                trainingLogger.Message($"Took {dataSets.Count} rows");
            }

            trainingLogger.Message("Training started");

            var completed = network.Train(
                trainingDataSets: dataSets,
                learningRate: learningRate,
                weightDecay: weightDecay,
                learningDataPercentage: learningDataRatio,
                epochs: epochs,
                momentum: momentum
            );

            trainingLogger.Message(completed ? "Finished" : "Stopped");
            TrainingCompleted?.Invoke(this, completed ? ProcessResult.Success : ProcessResult.Failure);
        }

        public void Predict(object[] inputs)
        {
            predictionLogger.Message($"{BELT}{DateTime.Now.TimeOfDay}{BELT}");
            predictionLogger.Message("Normalizing inputs.");

            double[] normalizedInputs = new double[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == null)
                {
                    predictionLogger.Message("Aborted. Value set contains null.");
                    PredictionCompleted?.Invoke(this, ProcessResult.Failure);
                    return;
                };

                normalizedInputs[i] = initializers[i].TryGetValue(inputs[i]).Value;
            }

            predictionLogger.Message("Starting prediction.");
            var result = network.Predict(normalizedInputs);

            predictionLogger.Message($"Finished with results:");

            foreach (var output in result)
            {
                predictionLogger.Message(output.ToString());
            }

            PredictionCompleted?.Invoke(this, ProcessResult.Success);
        }

        public void StopTraining()
        {
            trainingLogger.Message("Aborting...");
            network.Stop();
        }

        private double[] CreateOutput(long fatalities)
        {
            var outputs = new double[outputIntervals.Length];
            
            for (int i = 0; i < outputIntervals.Length; i++)
            {
                outputs[i] = 
                    (outputIntervals[i].Low == null || outputIntervals[i].Low <= fatalities)
                    && (outputIntervals[i].High == null || outputIntervals[i].High >= fatalities) 
                        ? 1 : 0;
            }

            return outputs;
        }

        private void OnTrainingEpochComplete(object sender, TrainingEpochCompletedEventArgs e)
        {
            trainingLogger.Message($"Epoch {e.Epoch}, Accuracy {e.Accuracy}, MSE {e.MeanSquareError}");
        }
    }
}
