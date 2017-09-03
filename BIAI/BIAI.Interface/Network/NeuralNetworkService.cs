using BIAI.Data;
using BIAI.Interface.Columns;
using BIAI.Interface.Logging;
using BIAI.Network;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BIAI.Interface.Network
{
    public class NeuralNetworkService
    {
        private const string BELT = "--------------";

        public event EventHandler TrainingCompleted;

        private NeuralNetwork network;
        private IReadOnlyCollection<ColumnSetting> columns;
        private Logger log;

        public NeuralNetworkService(IEnumerable<ColumnSetting> columnSettings, Logger logger)
        {
            columns = columnSettings.Where(x => x.Selected).ToList();
            network = new NeuralNetwork(columns.Count(), columns.Count(), 4);
            log = logger;
        }

        public void Start()
        {
            var dataSets = new List<TrainingDataSet>();

            log.Message($"{BELT}{DateTime.Now.TimeOfDay}{BELT}");
            log.Message("Opening connection to database");
            using (var db = new GlobalTerrorismContext())
            {
                log.Message("Preparing");

                var count = db.AttackRecords.Count();
                var sampleRecord = db.AttackRecords.First();
                var initializers = columns.Select(x => new InputInitializer(x.PropertyInfo, sampleRecord)).ToList();

                log.Message("Downloading data");
                var attackRecords = db.AttackRecords.ToList();

                log.Message("Normalizing data");
                for (int i = 0; i < count; i++)
                {
                    foreach (var initializer in initializers)
                    {
                        initializer.UpdateLimits(attackRecords[i]);
                    }

                    //log.Progress($"Normalizing data: {(float)i / count * 100}%");
                }

                log.Message("Creating data sets");
                //log.Finish();

                for (int i = 0; i < count; i++)
                {
                    var dataSet = new TrainingDataSet
                    {
                        Inputs = initializers.Select(x => x.GetValue(attackRecords[i])).ToArray(),
                        Outputs = new double[4].Initialize(0)
                    };

                    //log.Progress($"Creating data sets: {(float)i / count * 100}%");

                    dataSets.Add(dataSet);
                }

                //log.Finish();
            }

            log.Message("Training started");

            network.Train(
                trainingDataSets: dataSets,
                learningRate: 0.1,
                learningDataPercentage: 0.7
            );

            log.Message("Finished");
            TrainingCompleted?.Invoke(this, EventArgs.Empty);
        }

        public void Predict()
        {
            network.Predict(null);
        }
    }
}
