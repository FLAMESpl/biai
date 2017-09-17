using BIAI.Data.Model;
using BIAI.Interface.Columns;
using BIAI.Interface.Logging;
using BIAI.Interface.Network;
using BIAI.Interface.Prediction;
using BIAI.Interface.Prediction.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BIAI.Interface
{
    public partial class Form : System.Windows.Forms.Form
    {
        private const string FATALITIES = "Fatalities";

        private NeuralNetworkService neuralNetworkService;
        private Logger trainingLogger;
        private Logger predictionLogger;
        private bool trainingInProgress = false;
        private bool predictionInProgress = false;

        public Form()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var columns = typeof(AttackRecord).GetProperties();
            foreach (var column in columns)
            {
                if (column.Name == FATALITIES || !column.PropertyType.IsValueType)
                    continue;

                columnsBindingSource.Add(new ColumnSetting(column, false));
            }

            trainingLogger = new Logger(s => SetText(s, textBoxTrainingOutput));
            predictionLogger = new Logger(s => SetText(s, textBoxPredictOutput));
        }

        private void OnClickNext(object sender, EventArgs e)
        {
            tabPagePrediction.SelectedIndex++;
        }

        private void OnClickStart(object sender, EventArgs e)
        {
            if (!trainingInProgress)
            {
                double learningRate;
                double learningDataRatio;

                if (!Double.TryParse(textBoxLearningRate.Text, out learningRate))
                {
                    ShowError("Could not parse learning rate value.");
                    return;
                }

                if (!Double.TryParse(textBoxLearningDataRatio.Text, out learningDataRatio))
                {
                    ShowError("Could not parse learning data ratio value.");
                    return;
                }

                if (learningDataRatio >= 1d)
                {
                    ShowError("Learning ratio must be less than 1.");
                    return;
                }

                var intervals = outputIntervalsBindingSource.Cast<Limits>();
                if (!ValidateLimits(intervals))
                    return;
                
                var neuralNetworkService = new NeuralNetworkService(
                    columnSettings: columnsBindingSource.List.Cast<ColumnSetting>(),
                    trainingLogger: trainingLogger,
                    predictingLogger: predictionLogger,
                    outputIntervals: intervals,
                    learningRate: learningRate, 
                    learningDataRatio: learningDataRatio);

                neuralNetworkService.TrainingCompleted += OnNetworkTrainingComplete;
                neuralNetworkService.PredictionCompleted += OnPredictionComplete;
                var thread = new Thread(neuralNetworkService.Start);
                thread.Start();
                trainingInProgress = true;
            }
        }

        private void OnCheckSelected(object sender, EventArgs e)
        {
            foreach (var row in columnsDataGrid.SelectedRows.Cast<DataGridViewRow>())
            {
                ((ColumnSetting)columnsBindingSource.List[row.Index]).Selected = true;
                columnsDataGrid.InvalidateRow(row.Index);
            }
        }

        private void OnUncheckSelected(object sender, EventArgs e)
        {
            foreach (var row in columnsDataGrid.SelectedRows.Cast<DataGridViewRow>())
            {
                ((ColumnSetting)columnsBindingSource.List[row.Index]).Selected = false;
                columnsDataGrid.InvalidateRow(row.Index);
            }
        }

        private void OnNetworkTrainingComplete(object sender, ProcessResult result)
        {
            trainingInProgress = false;

            if (result == ProcessResult.Success)
            {
                neuralNetworkService = (NeuralNetworkService)sender;
                UpdatePredictionGrid(inputsGrid);
            }
        }

        private void OnClickPredict(object sender, EventArgs e)
        {
            if (neuralNetworkService == null)
            {
                ShowError("Invalid input provided.");
            }

            if (!predictionInProgress)
            {
                try
                {
                    var values = inputsGrid.GetValues();
                    var thread = new Thread(() => neuralNetworkService.Predict(values));
                    thread.Start();
                    predictionInProgress = true;
                }
                catch (InputValueException)
                {
                    ShowError("Invalid input provided.");
                }
            }
        }

        private void OnPredictionComplete(object sender, ProcessResult result)
        {
            predictionInProgress = false;
        }

        private void OnClickAddInterval(object sender, EventArgs e)
        {
            outputIntervalsBindingSource.Add(new Limits(null, null));
        }

        private void OnOutputIntervalsBindingError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ShowError("Interval output limit must be an empty or integral value.");
        }

        private void SetText(string text, Control control)
        {
            if (InvokeRequired)
            {
                Invoke((Action<string, Control>)SetText, text, control);
                return;
            }
            control.Text = text;
        }

        private void UpdatePredictionGrid(InputsGrid inputsGrid)
        {
            if (InvokeRequired)
            {
                Invoke((Action<InputsGrid>)UpdatePredictionGrid, inputsGrid);
                return;
            }
            inputsGrid.SetColumns(neuralNetworkService.Columns);
        }

        private void ShowError(string text) => MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private bool ValidateLimits(IEnumerable<Limits> limitsCollection)
        {
            var limitsSoFar = new List<Limits>();

            foreach (var limits in limitsCollection)
            {
                if (limits.Low > limits.High)
                {
                    ShowError("Bottom limit is higher than upper.");
                    return false;
                }

                if (limitsSoFar.Any(x => (x.High == null || limits.Low == null || x.High > limits.Low) 
                                    && (x.Low == null || limits.High == null || x.Low < limits.High)))
                {
                    ShowError("Output intervals are overlapping.");
                    return false;
                }

                limitsSoFar.Add(limits);
            }

            return true;
        }
    }
}
