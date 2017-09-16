using BIAI.Data.Model;
using BIAI.Interface.Columns;
using BIAI.Interface.Logging;
using BIAI.Interface.Network;
using BIAI.Interface.Prediction;
using BIAI.Interface.Prediction.Controls;
using System;
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
                var arr = new Limits[4] { new Limits(0, 0), new Limits(1, 3), new Limits(4, 6), new Limits(7, null) };
                var neuralNetworkService = new NeuralNetworkService(columnsBindingSource.List.Cast<ColumnSetting>(), trainingLogger, predictionLogger, arr);
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
    }
}
