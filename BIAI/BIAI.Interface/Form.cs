using BIAI.Data.Model;
using BIAI.Interface.Columns;
using BIAI.Interface.Logging;
using BIAI.Interface.Network;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BIAI.Interface
{
    public partial class Form : System.Windows.Forms.Form
    {
        private NeuralNetworkService neuralNetworkService;
        private Logger trainingLogger;
        private bool trainingInProgress = false;

        public Form()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var columns = typeof(AttackRecord).GetProperties();
            foreach (var column in columns)
            {
                columnsBindingSource.Add(new ColumnSetting(column, false));
            }

            trainingLogger = new Logger(s => SetText(s, textBoxTrainingOutput));
        }

        private void OnClickNext(object sender, EventArgs e)
        {
            tabPagePrediction.SelectedIndex++;
        }

        private void OnClickStart(object sender, EventArgs e)
        {
            if (!trainingInProgress)
            {
                var neuralNetworkService = new NeuralNetworkService(columnsBindingSource.List.Cast<ColumnSetting>(), trainingLogger);
                neuralNetworkService.TrainingCompleted += OnNetworkTrainingComplete;
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

        private void OnNetworkTrainingComplete(object sender, EventArgs e)
        {
            neuralNetworkService = (NeuralNetworkService)sender;
            trainingInProgress = false;
        }

        private void SetText(string text, Control control)
        {
            if (InvokeRequired)
            {
                Invoke((Action<string, Control>)SetText, new object[] { text, control });
                return;
            }
            control.Text = text;
        }
    }
}
