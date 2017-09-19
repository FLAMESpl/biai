namespace BIAI.Interface
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPagePrediction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelColumns = new System.Windows.Forms.TableLayoutPanel();
            this.columnsDataGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelButtonsColumns = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCheckSelected = new System.Windows.Forms.Button();
            this.buttonUncheckSelected = new System.Windows.Forms.Button();
            this.buttonNextColumns = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelNetwork = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelNeuralNetworkSettings = new System.Windows.Forms.TableLayoutPanel();
            this.labelLearningDataRatio = new System.Windows.Forms.Label();
            this.labelLearningRate = new System.Windows.Forms.Label();
            this.textBoxLearningDataRatio = new System.Windows.Forms.TextBox();
            this.textBoxLearningRate = new System.Windows.Forms.TextBox();
            this.labelEpochs = new System.Windows.Forms.Label();
            this.textBoxEpochs = new System.Windows.Forms.TextBox();
            this.textBoxHiddenNeurons = new System.Windows.Forms.TextBox();
            this.labelHiddenNeurons = new System.Windows.Forms.Label();
            this.labelRowLimit = new System.Windows.Forms.Label();
            this.textBoxRowLimit = new System.Windows.Forms.TextBox();
            this.labelWeightDecay = new System.Windows.Forms.Label();
            this.textBoxWeightDecay = new System.Windows.Forms.TextBox();
            this.labelMomentum = new System.Windows.Forms.Label();
            this.textBoxMomentum = new System.Windows.Forms.TextBox();
            this.gridOutputIntervals = new System.Windows.Forms.DataGridView();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputIntervalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNextNetwork = new System.Windows.Forms.Button();
            this.buttonAddInterval = new System.Windows.Forms.Button();
            this.tabPageTraining = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTraining = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNextTraining = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxTrainingOutput = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPrediction = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPredict = new System.Windows.Forms.Button();
            this.textBoxPredictOutput = new System.Windows.Forms.TextBox();
            this.inputsGrid = new BIAI.Interface.Prediction.Controls.InputsGrid();
            this.tabPagePrediction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).BeginInit();
            this.tableLayoutPanelButtonsColumns.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanelNetwork.SuspendLayout();
            this.tableLayoutPanelNeuralNetworkSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutputIntervals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputIntervalsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageTraining.SuspendLayout();
            this.tableLayoutPanelTraining.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanelPrediction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPagePrediction
            // 
            this.tabPagePrediction.Controls.Add(this.tabPage1);
            this.tabPagePrediction.Controls.Add(this.tabPage2);
            this.tabPagePrediction.Controls.Add(this.tabPageTraining);
            this.tabPagePrediction.Controls.Add(this.tabPage3);
            this.tabPagePrediction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPagePrediction.Location = new System.Drawing.Point(0, 0);
            this.tabPagePrediction.Name = "tabPagePrediction";
            this.tabPagePrediction.SelectedIndex = 0;
            this.tabPagePrediction.Size = new System.Drawing.Size(381, 430);
            this.tabPagePrediction.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanelColumns);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Columns";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelColumns
            // 
            this.tableLayoutPanelColumns.ColumnCount = 1;
            this.tableLayoutPanelColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelColumns.Controls.Add(this.columnsDataGrid, 0, 0);
            this.tableLayoutPanelColumns.Controls.Add(this.tableLayoutPanelButtonsColumns, 0, 1);
            this.tableLayoutPanelColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelColumns.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelColumns.Name = "tableLayoutPanelColumns";
            this.tableLayoutPanelColumns.RowCount = 2;
            this.tableLayoutPanelColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelColumns.Size = new System.Drawing.Size(367, 398);
            this.tableLayoutPanelColumns.TabIndex = 0;
            // 
            // columnsDataGrid
            // 
            this.columnsDataGrid.AutoGenerateColumns = false;
            this.columnsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.columnsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.selectedDataGridViewCheckBoxColumn});
            this.columnsDataGrid.DataSource = this.columnsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.columnsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.columnsDataGrid.Name = "columnsDataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.columnsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.columnsDataGrid.Size = new System.Drawing.Size(361, 356);
            this.columnsDataGrid.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            this.selectedDataGridViewCheckBoxColumn.Width = 75;
            // 
            // columnsBindingSource
            // 
            this.columnsBindingSource.DataSource = typeof(BIAI.Interface.Columns.ColumnSetting);
            // 
            // tableLayoutPanelButtonsColumns
            // 
            this.tableLayoutPanelButtonsColumns.ColumnCount = 3;
            this.tableLayoutPanelButtonsColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtonsColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanelButtonsColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanelButtonsColumns.Controls.Add(this.buttonCheckSelected, 0, 0);
            this.tableLayoutPanelButtonsColumns.Controls.Add(this.buttonUncheckSelected, 1, 0);
            this.tableLayoutPanelButtonsColumns.Controls.Add(this.buttonNextColumns, 2, 0);
            this.tableLayoutPanelButtonsColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtonsColumns.Location = new System.Drawing.Point(3, 365);
            this.tableLayoutPanelButtonsColumns.Name = "tableLayoutPanelButtonsColumns";
            this.tableLayoutPanelButtonsColumns.RowCount = 1;
            this.tableLayoutPanelButtonsColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtonsColumns.Size = new System.Drawing.Size(361, 30);
            this.tableLayoutPanelButtonsColumns.TabIndex = 1;
            // 
            // buttonCheckSelected
            // 
            this.buttonCheckSelected.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCheckSelected.Location = new System.Drawing.Point(61, 3);
            this.buttonCheckSelected.Name = "buttonCheckSelected";
            this.buttonCheckSelected.Size = new System.Drawing.Size(105, 24);
            this.buttonCheckSelected.TabIndex = 0;
            this.buttonCheckSelected.Text = "Check selected";
            this.buttonCheckSelected.UseVisualStyleBackColor = true;
            this.buttonCheckSelected.Click += new System.EventHandler(this.OnCheckSelected);
            // 
            // buttonUncheckSelected
            // 
            this.buttonUncheckSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUncheckSelected.Location = new System.Drawing.Point(172, 3);
            this.buttonUncheckSelected.Name = "buttonUncheckSelected";
            this.buttonUncheckSelected.Size = new System.Drawing.Size(105, 24);
            this.buttonUncheckSelected.TabIndex = 1;
            this.buttonUncheckSelected.Text = "Uncheck selected";
            this.buttonUncheckSelected.UseVisualStyleBackColor = true;
            this.buttonUncheckSelected.Click += new System.EventHandler(this.OnUncheckSelected);
            // 
            // buttonNextColumns
            // 
            this.buttonNextColumns.Location = new System.Drawing.Point(283, 3);
            this.buttonNextColumns.Name = "buttonNextColumns";
            this.buttonNextColumns.Size = new System.Drawing.Size(75, 23);
            this.buttonNextColumns.TabIndex = 2;
            this.buttonNextColumns.Text = "Next";
            this.buttonNextColumns.UseVisualStyleBackColor = true;
            this.buttonNextColumns.Click += new System.EventHandler(this.OnClickNext);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanelNetwork);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Network";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelNetwork
            // 
            this.tableLayoutPanelNetwork.ColumnCount = 1;
            this.tableLayoutPanelNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelNetwork.Controls.Add(this.tableLayoutPanelNeuralNetworkSettings, 0, 0);
            this.tableLayoutPanelNetwork.Controls.Add(this.gridOutputIntervals, 0, 1);
            this.tableLayoutPanelNetwork.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanelNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNetwork.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelNetwork.Name = "tableLayoutPanelNetwork";
            this.tableLayoutPanelNetwork.RowCount = 3;
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelNetwork.Size = new System.Drawing.Size(367, 398);
            this.tableLayoutPanelNetwork.TabIndex = 1;
            // 
            // tableLayoutPanelNeuralNetworkSettings
            // 
            this.tableLayoutPanelNeuralNetworkSettings.ColumnCount = 3;
            this.tableLayoutPanelNeuralNetworkSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanelNeuralNetworkSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanelNeuralNetworkSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.labelLearningDataRatio, 0, 0);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.labelLearningRate, 0, 1);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.textBoxLearningDataRatio, 1, 0);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.textBoxLearningRate, 1, 1);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.labelEpochs, 0, 2);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.textBoxEpochs, 1, 2);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.textBoxHiddenNeurons, 1, 3);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.labelHiddenNeurons, 0, 3);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.labelRowLimit, 0, 4);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.textBoxRowLimit, 1, 4);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.labelWeightDecay, 0, 5);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.textBoxWeightDecay, 1, 5);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.labelMomentum, 0, 6);
            this.tableLayoutPanelNeuralNetworkSettings.Controls.Add(this.textBoxMomentum, 1, 6);
            this.tableLayoutPanelNeuralNetworkSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNeuralNetworkSettings.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelNeuralNetworkSettings.Name = "tableLayoutPanelNeuralNetworkSettings";
            this.tableLayoutPanelNeuralNetworkSettings.RowCount = 7;
            this.tableLayoutPanelNeuralNetworkSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28566F));
            this.tableLayoutPanelNeuralNetworkSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28566F));
            this.tableLayoutPanelNeuralNetworkSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28566F));
            this.tableLayoutPanelNeuralNetworkSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28424F));
            this.tableLayoutPanelNeuralNetworkSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanelNeuralNetworkSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanelNeuralNetworkSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanelNeuralNetworkSettings.Size = new System.Drawing.Size(361, 170);
            this.tableLayoutPanelNeuralNetworkSettings.TabIndex = 2;
            // 
            // labelLearningDataRatio
            // 
            this.labelLearningDataRatio.AutoSize = true;
            this.labelLearningDataRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLearningDataRatio.Location = new System.Drawing.Point(3, 0);
            this.labelLearningDataRatio.Name = "labelLearningDataRatio";
            this.labelLearningDataRatio.Size = new System.Drawing.Size(126, 24);
            this.labelLearningDataRatio.TabIndex = 0;
            this.labelLearningDataRatio.Text = "Learning data ratio";
            this.labelLearningDataRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLearningRate
            // 
            this.labelLearningRate.AutoSize = true;
            this.labelLearningRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLearningRate.Location = new System.Drawing.Point(3, 24);
            this.labelLearningRate.Name = "labelLearningRate";
            this.labelLearningRate.Size = new System.Drawing.Size(126, 24);
            this.labelLearningRate.TabIndex = 1;
            this.labelLearningRate.Text = "Learning rate";
            this.labelLearningRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLearningDataRatio
            // 
            this.textBoxLearningDataRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLearningDataRatio.Location = new System.Drawing.Point(135, 3);
            this.textBoxLearningDataRatio.Name = "textBoxLearningDataRatio";
            this.textBoxLearningDataRatio.Size = new System.Drawing.Size(86, 20);
            this.textBoxLearningDataRatio.TabIndex = 2;
            this.textBoxLearningDataRatio.Text = "0,7";
            // 
            // textBoxLearningRate
            // 
            this.textBoxLearningRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLearningRate.Location = new System.Drawing.Point(135, 27);
            this.textBoxLearningRate.Name = "textBoxLearningRate";
            this.textBoxLearningRate.Size = new System.Drawing.Size(86, 20);
            this.textBoxLearningRate.TabIndex = 3;
            this.textBoxLearningRate.Text = "0,5";
            // 
            // labelEpochs
            // 
            this.labelEpochs.AutoSize = true;
            this.labelEpochs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEpochs.Location = new System.Drawing.Point(3, 48);
            this.labelEpochs.Name = "labelEpochs";
            this.labelEpochs.Size = new System.Drawing.Size(126, 24);
            this.labelEpochs.TabIndex = 4;
            this.labelEpochs.Text = "Epochs";
            this.labelEpochs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEpochs
            // 
            this.textBoxEpochs.Location = new System.Drawing.Point(135, 51);
            this.textBoxEpochs.Name = "textBoxEpochs";
            this.textBoxEpochs.Size = new System.Drawing.Size(86, 20);
            this.textBoxEpochs.TabIndex = 5;
            this.textBoxEpochs.Text = "1";
            // 
            // textBoxHiddenNeurons
            // 
            this.textBoxHiddenNeurons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHiddenNeurons.Location = new System.Drawing.Point(135, 75);
            this.textBoxHiddenNeurons.Name = "textBoxHiddenNeurons";
            this.textBoxHiddenNeurons.Size = new System.Drawing.Size(86, 20);
            this.textBoxHiddenNeurons.TabIndex = 6;
            this.textBoxHiddenNeurons.Text = "8";
            // 
            // labelHiddenNeurons
            // 
            this.labelHiddenNeurons.AutoSize = true;
            this.labelHiddenNeurons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHiddenNeurons.Location = new System.Drawing.Point(3, 72);
            this.labelHiddenNeurons.Name = "labelHiddenNeurons";
            this.labelHiddenNeurons.Size = new System.Drawing.Size(126, 24);
            this.labelHiddenNeurons.TabIndex = 7;
            this.labelHiddenNeurons.Text = "Hidden neurons";
            this.labelHiddenNeurons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRowLimit
            // 
            this.labelRowLimit.AutoSize = true;
            this.labelRowLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRowLimit.Location = new System.Drawing.Point(3, 96);
            this.labelRowLimit.Name = "labelRowLimit";
            this.labelRowLimit.Size = new System.Drawing.Size(126, 24);
            this.labelRowLimit.TabIndex = 8;
            this.labelRowLimit.Text = "Row limit";
            this.labelRowLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRowLimit
            // 
            this.textBoxRowLimit.Location = new System.Drawing.Point(135, 99);
            this.textBoxRowLimit.Name = "textBoxRowLimit";
            this.textBoxRowLimit.Size = new System.Drawing.Size(86, 20);
            this.textBoxRowLimit.TabIndex = 9;
            // 
            // labelWeightDecay
            // 
            this.labelWeightDecay.AutoSize = true;
            this.labelWeightDecay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWeightDecay.Location = new System.Drawing.Point(3, 120);
            this.labelWeightDecay.Name = "labelWeightDecay";
            this.labelWeightDecay.Size = new System.Drawing.Size(126, 24);
            this.labelWeightDecay.TabIndex = 10;
            this.labelWeightDecay.Text = "Weight decay";
            this.labelWeightDecay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWeightDecay
            // 
            this.textBoxWeightDecay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWeightDecay.Location = new System.Drawing.Point(135, 123);
            this.textBoxWeightDecay.Name = "textBoxWeightDecay";
            this.textBoxWeightDecay.Size = new System.Drawing.Size(86, 20);
            this.textBoxWeightDecay.TabIndex = 11;
            this.textBoxWeightDecay.Text = "0,001";
            // 
            // labelMomentum
            // 
            this.labelMomentum.AutoSize = true;
            this.labelMomentum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMomentum.Location = new System.Drawing.Point(3, 144);
            this.labelMomentum.Name = "labelMomentum";
            this.labelMomentum.Size = new System.Drawing.Size(126, 26);
            this.labelMomentum.TabIndex = 12;
            this.labelMomentum.Text = "Momentum";
            this.labelMomentum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMomentum
            // 
            this.textBoxMomentum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMomentum.Location = new System.Drawing.Point(135, 147);
            this.textBoxMomentum.Name = "textBoxMomentum";
            this.textBoxMomentum.Size = new System.Drawing.Size(86, 20);
            this.textBoxMomentum.TabIndex = 13;
            this.textBoxMomentum.Text = "0,001";
            // 
            // gridOutputIntervals
            // 
            this.gridOutputIntervals.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOutputIntervals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridOutputIntervals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutputIntervals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lowDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn});
            this.gridOutputIntervals.DataSource = this.outputIntervalsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOutputIntervals.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridOutputIntervals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOutputIntervals.Location = new System.Drawing.Point(3, 179);
            this.gridOutputIntervals.Name = "gridOutputIntervals";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOutputIntervals.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridOutputIntervals.Size = new System.Drawing.Size(361, 180);
            this.gridOutputIntervals.TabIndex = 3;
            this.gridOutputIntervals.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.OnOutputIntervalsBindingError);
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "Low";
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "High";
            this.highDataGridViewTextBoxColumn.HeaderText = "High";
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            // 
            // outputIntervalsBindingSource
            // 
            this.outputIntervalsBindingSource.DataSource = typeof(BIAI.Interface.Network.Limits);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Controls.Add(this.buttonNextNetwork, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddInterval, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 365);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 30);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonNextNetwork
            // 
            this.buttonNextNetwork.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNextNetwork.Location = new System.Drawing.Point(283, 3);
            this.buttonNextNetwork.Name = "buttonNextNetwork";
            this.buttonNextNetwork.Size = new System.Drawing.Size(75, 24);
            this.buttonNextNetwork.TabIndex = 1;
            this.buttonNextNetwork.Text = "Next";
            this.buttonNextNetwork.UseVisualStyleBackColor = true;
            this.buttonNextNetwork.Click += new System.EventHandler(this.OnClickNext);
            // 
            // buttonAddInterval
            // 
            this.buttonAddInterval.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddInterval.Location = new System.Drawing.Point(201, 3);
            this.buttonAddInterval.Name = "buttonAddInterval";
            this.buttonAddInterval.Size = new System.Drawing.Size(75, 24);
            this.buttonAddInterval.TabIndex = 2;
            this.buttonAddInterval.Text = "Add interval";
            this.buttonAddInterval.UseVisualStyleBackColor = true;
            this.buttonAddInterval.Click += new System.EventHandler(this.OnClickAddInterval);
            // 
            // tabPageTraining
            // 
            this.tabPageTraining.Controls.Add(this.tableLayoutPanelTraining);
            this.tabPageTraining.Location = new System.Drawing.Point(4, 22);
            this.tabPageTraining.Name = "tabPageTraining";
            this.tabPageTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTraining.Size = new System.Drawing.Size(373, 404);
            this.tabPageTraining.TabIndex = 2;
            this.tabPageTraining.Text = "Training";
            this.tabPageTraining.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTraining
            // 
            this.tableLayoutPanelTraining.ColumnCount = 1;
            this.tableLayoutPanelTraining.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTraining.Controls.Add(this.tableLayoutPanelButtons, 0, 1);
            this.tableLayoutPanelTraining.Controls.Add(this.textBoxTrainingOutput, 0, 0);
            this.tableLayoutPanelTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTraining.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTraining.Name = "tableLayoutPanelTraining";
            this.tableLayoutPanelTraining.RowCount = 2;
            this.tableLayoutPanelTraining.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTraining.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelTraining.Size = new System.Drawing.Size(367, 398);
            this.tableLayoutPanelTraining.TabIndex = 1;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 3;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonNextTraining, 2, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonStart, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonStop, 1, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 365);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(361, 30);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonNextTraining
            // 
            this.buttonNextTraining.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNextTraining.Location = new System.Drawing.Point(283, 3);
            this.buttonNextTraining.Name = "buttonNextTraining";
            this.buttonNextTraining.Size = new System.Drawing.Size(75, 24);
            this.buttonNextTraining.TabIndex = 6;
            this.buttonNextTraining.Text = "Next";
            this.buttonNextTraining.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStart.Location = new System.Drawing.Point(120, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 24);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.OnClickStart);
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStop.Location = new System.Drawing.Point(201, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(76, 24);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.OnClickStop);
            // 
            // textBoxTrainingOutput
            // 
            this.textBoxTrainingOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTrainingOutput.Location = new System.Drawing.Point(3, 3);
            this.textBoxTrainingOutput.Multiline = true;
            this.textBoxTrainingOutput.Name = "textBoxTrainingOutput";
            this.textBoxTrainingOutput.ReadOnly = true;
            this.textBoxTrainingOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTrainingOutput.Size = new System.Drawing.Size(361, 356);
            this.textBoxTrainingOutput.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanelPrediction);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(373, 404);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Prediction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPrediction
            // 
            this.tableLayoutPanelPrediction.ColumnCount = 1;
            this.tableLayoutPanelPrediction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrediction.Controls.Add(this.buttonPredict, 0, 2);
            this.tableLayoutPanelPrediction.Controls.Add(this.textBoxPredictOutput, 0, 1);
            this.tableLayoutPanelPrediction.Controls.Add(this.inputsGrid, 0, 0);
            this.tableLayoutPanelPrediction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrediction.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPrediction.Name = "tableLayoutPanelPrediction";
            this.tableLayoutPanelPrediction.RowCount = 3;
            this.tableLayoutPanelPrediction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrediction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanelPrediction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelPrediction.Size = new System.Drawing.Size(367, 398);
            this.tableLayoutPanelPrediction.TabIndex = 0;
            // 
            // buttonPredict
            // 
            this.buttonPredict.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPredict.Location = new System.Drawing.Point(289, 365);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(75, 30);
            this.buttonPredict.TabIndex = 0;
            this.buttonPredict.Text = "Predict";
            this.buttonPredict.UseVisualStyleBackColor = true;
            this.buttonPredict.Click += new System.EventHandler(this.OnClickPredict);
            // 
            // textBoxPredictOutput
            // 
            this.textBoxPredictOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPredictOutput.Location = new System.Drawing.Point(3, 201);
            this.textBoxPredictOutput.Multiline = true;
            this.textBoxPredictOutput.Name = "textBoxPredictOutput";
            this.textBoxPredictOutput.ReadOnly = true;
            this.textBoxPredictOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPredictOutput.Size = new System.Drawing.Size(361, 158);
            this.textBoxPredictOutput.TabIndex = 1;
            // 
            // inputsGrid
            // 
            this.inputsGrid.AutoScroll = true;
            this.inputsGrid.CellHeight = 30F;
            this.inputsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsGrid.Location = new System.Drawing.Point(3, 3);
            this.inputsGrid.Name = "inputsGrid";
            this.inputsGrid.Size = new System.Drawing.Size(361, 192);
            this.inputsGrid.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 430);
            this.Controls.Add(this.tabPagePrediction);
            this.Name = "Form";
            this.Text = "Global Terrorism Neural Network";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tabPagePrediction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanelColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.columnsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).EndInit();
            this.tableLayoutPanelButtonsColumns.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanelNetwork.ResumeLayout(false);
            this.tableLayoutPanelNeuralNetworkSettings.ResumeLayout(false);
            this.tableLayoutPanelNeuralNetworkSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutputIntervals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputIntervalsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPageTraining.ResumeLayout(false);
            this.tableLayoutPanelTraining.ResumeLayout(false);
            this.tableLayoutPanelTraining.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanelPrediction.ResumeLayout(false);
            this.tableLayoutPanelPrediction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPagePrediction;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColumns;
        private System.Windows.Forms.DataGridView columnsDataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource columnsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNetwork;
        private System.Windows.Forms.TabPage tabPageTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.TextBox textBoxTrainingOutput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrediction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtonsColumns;
        private System.Windows.Forms.Button buttonCheckSelected;
        private System.Windows.Forms.Button buttonUncheckSelected;
        private System.Windows.Forms.Button buttonNextColumns;
        private System.Windows.Forms.Button buttonPredict;
        private System.Windows.Forms.TextBox textBoxPredictOutput;
        private Prediction.Controls.InputsGrid inputsGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNeuralNetworkSettings;
        private System.Windows.Forms.Label labelLearningDataRatio;
        private System.Windows.Forms.Label labelLearningRate;
        private System.Windows.Forms.TextBox textBoxLearningDataRatio;
        private System.Windows.Forms.TextBox textBoxLearningRate;
        private System.Windows.Forms.DataGridView gridOutputIntervals;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource outputIntervalsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonNextNetwork;
        private System.Windows.Forms.Button buttonAddInterval;
        private System.Windows.Forms.Label labelEpochs;
        private System.Windows.Forms.TextBox textBoxEpochs;
        private System.Windows.Forms.TextBox textBoxHiddenNeurons;
        private System.Windows.Forms.Label labelHiddenNeurons;
        private System.Windows.Forms.Label labelRowLimit;
        private System.Windows.Forms.TextBox textBoxRowLimit;
        private System.Windows.Forms.Button buttonNextTraining;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelWeightDecay;
        private System.Windows.Forms.TextBox textBoxWeightDecay;
        private System.Windows.Forms.Label labelMomentum;
        private System.Windows.Forms.TextBox textBoxMomentum;
    }
}

