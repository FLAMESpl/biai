using BIAI.Data;
using BIAI.Interface.Columns;
using BIAI.Network;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BIAI.Interface.Network
{
    public class NeuralNetworkService
    {
        private NeuralNetwork network;
        private IReadOnlyCollection<ColumnSetting> columns;
        private Action<string> log;

        public NeuralNetworkService(IEnumerable<ColumnSetting> columnSettings, Action<string> loggerDelegate)
        {
            columns = columnSettings.Where(x => x.Selected).ToList();
            network = new NeuralNetwork(columnSettings.Count(), columnSettings.Count(), 4);
            log = loggerDelegate;
        }

        public void Start()
        {
            var dataSets = new List<TrainingDataSet>();

            using (var db = new GlobalTerrorismContext())
            {
                var count = db.AttackRecords.Count();
                var sampleRecord = db.AttackRecords.First();
                var initializers = columns.Select(x => new InputInitializer(x.PropertyInfo, sampleRecord)).ToList();

                log($"Downloading data");
                var attackRecords = db.AttackRecords.ToList();

                for (int i = 0; i < count; i++)
                {
                    foreach (var initializer in initializers)
                    {
                        initializer.UpdateLimits(attackRecords[i]);
                        log($"Normalizing data: {(float)i / count * 100}%");
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    var dataSet = new TrainingDataSet
                    {
                        Inputs = initializers.Select(x => x.GetValue(attackRecords[i])).ToArray(),
                        Outputs = new double[4].Initialize(0)
                    };

                    log($"Creating data sets: {(float)i / count * 100}%");

                    dataSets.Add(dataSet);
                }
            }

            return;

            network.Train(
                trainingDataSets: dataSets,
                learningRate: 0.1,
                learningDataPercentage: 0.7
            );
        }

        public void Predict()
        {
            network.Predict(null);
        }
    }
}
