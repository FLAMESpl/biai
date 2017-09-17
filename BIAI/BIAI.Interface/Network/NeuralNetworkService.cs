using BIAI.Data;
using BIAI.Interface.Columns;
using BIAI.Interface.Logging;
using BIAI.Network;
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
        private Logger predictingLogger;
        private Limits[] outputIntervals;
        private List<InputInitializer> initializers;
        private double learningRate;
        private double learningDataRatio;

        public IReadOnlyList<ColumnSetting> Columns { get; }

        public NeuralNetworkService(IEnumerable<ColumnSetting> columnSettings, Logger trainingLogger, Logger predictingLogger, 
            IEnumerable<Limits> outputIntervals, double learningRate, double learningDataRatio)
        {
            this.outputIntervals = outputIntervals.ToArray();
            Columns = columnSettings.Where(x => x.Selected).ToList();
            network = new NeuralNetwork(Columns.Count, Columns.Count, this.outputIntervals.Length);
            this.trainingLogger = trainingLogger;
            this.predictingLogger = predictingLogger;
            this.learningRate = learningRate;
            this.learningDataRatio = learningDataRatio;
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

                    //log.Progress($"Normalizing data: {(float)i / count * 100}%");
                }

                trainingLogger.Message("Creating data sets");
                //log.Finish();

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

                    //log.Progress($"Creating data sets: {(float)i / count * 100}%");

                    dataSets.Add(dataSet);
                }

                //log.Finish();
                trainingLogger.Message($"{nulls} records skipped as they contains nulls.");
            }

            trainingLogger.Message("Training started");

            network.Train(
                trainingDataSets: dataSets,
                learningRate: learningRate,
                learningDataPercentage: learningDataRatio
            );

            trainingLogger.Message("Finished");
            trainingLogger.Message($"Training accuracy: {network.Accuracy}");
            TrainingCompleted?.Invoke(this, ProcessResult.Success);
        }

        public void Predict(object[] inputs)
        {
            predictingLogger.Message($"{BELT}{DateTime.Now.TimeOfDay}{BELT}");
            predictingLogger.Message("Normalizing inputs.");

            double[] normalizedInputs = new double[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == null)
                {
                    predictingLogger.Message("Aborted. Value set contains null.");
                    PredictionCompleted?.Invoke(this, ProcessResult.Failure);
                    return;
                };

                normalizedInputs[i] = initializers[i].TryGetValue(inputs[i]).Value;
            }

            predictingLogger.Message("Starting prediction.");
            var result = network.Predict(normalizedInputs);

            predictingLogger.Message($"Finished with result {FormatOutput(result)}.");
            PredictionCompleted?.Invoke(this, ProcessResult.Success);
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

        private string FormatOutput(double[] outputs)
        {
            return $"{{{String.Join(";", outputs.Select(x => x.ToString()))}}}";
        }
    }
}
