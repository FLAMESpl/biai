using BIAI.Data.Model;
using BIAI.Interface.Columns;
using BIAI.Interface.Network;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BIAI.Interface
{
    public partial class Form : System.Windows.Forms.Form
    {
        private NeuralNetworkService neuralNetworkService;

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
        }

        private void OnClickNext(object sender, EventArgs e)
        {
            tabPagePrediction.SelectedIndex++;
        }

        private void OnClickStart(object sender, EventArgs e)
        {
            Action<string> loggerDelegate = s => textBoxTrainingOutput.Text = s;
            neuralNetworkService = new NeuralNetworkService(columnsBindingSource.List.Cast<ColumnSetting>(), loggerDelegate);
            neuralNetworkService.Start();
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
    }
}
