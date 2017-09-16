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
            this.buttonNextNetwork = new System.Windows.Forms.Button();
            this.tabPageTraining = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTraining = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNextTraining = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
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
            this.tabPagePrediction.Size = new System.Drawing.Size(413, 261);
            this.tabPagePrediction.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanelColumns);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 235);
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
            this.tableLayoutPanelColumns.Size = new System.Drawing.Size(399, 229);
            this.tableLayoutPanelColumns.TabIndex = 0;
            // 
            // columnsDataGrid
            // 
            this.columnsDataGrid.AutoGenerateColumns = false;
            this.columnsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.columnsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.selectedDataGridViewCheckBoxColumn});
            this.columnsDataGrid.DataSource = this.columnsBindingSource;
            this.columnsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.columnsDataGrid.Name = "columnsDataGrid";
            this.columnsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.columnsDataGrid.Size = new System.Drawing.Size(393, 187);
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
            this.tableLayoutPanelButtonsColumns.Location = new System.Drawing.Point(3, 196);
            this.tableLayoutPanelButtonsColumns.Name = "tableLayoutPanelButtonsColumns";
            this.tableLayoutPanelButtonsColumns.RowCount = 1;
            this.tableLayoutPanelButtonsColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtonsColumns.Size = new System.Drawing.Size(393, 30);
            this.tableLayoutPanelButtonsColumns.TabIndex = 1;
            // 
            // buttonCheckSelected
            // 
            this.buttonCheckSelected.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCheckSelected.Location = new System.Drawing.Point(93, 3);
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
            this.buttonUncheckSelected.Location = new System.Drawing.Point(204, 3);
            this.buttonUncheckSelected.Name = "buttonUncheckSelected";
            this.buttonUncheckSelected.Size = new System.Drawing.Size(105, 24);
            this.buttonUncheckSelected.TabIndex = 1;
            this.buttonUncheckSelected.Text = "Uncheck selected";
            this.buttonUncheckSelected.UseVisualStyleBackColor = true;
            this.buttonUncheckSelected.Click += new System.EventHandler(this.OnUncheckSelected);
            // 
            // buttonNextColumns
            // 
            this.buttonNextColumns.Location = new System.Drawing.Point(315, 3);
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
            this.tabPage2.Size = new System.Drawing.Size(405, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Network";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelNetwork
            // 
            this.tableLayoutPanelNetwork.ColumnCount = 1;
            this.tableLayoutPanelNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNetwork.Controls.Add(this.buttonNextNetwork, 0, 1);
            this.tableLayoutPanelNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNetwork.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelNetwork.Name = "tableLayoutPanelNetwork";
            this.tableLayoutPanelNetwork.RowCount = 2;
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelNetwork.Size = new System.Drawing.Size(399, 229);
            this.tableLayoutPanelNetwork.TabIndex = 1;
            // 
            // buttonNextNetwork
            // 
            this.buttonNextNetwork.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNextNetwork.Location = new System.Drawing.Point(321, 196);
            this.buttonNextNetwork.Name = "buttonNextNetwork";
            this.buttonNextNetwork.Size = new System.Drawing.Size(75, 30);
            this.buttonNextNetwork.TabIndex = 0;
            this.buttonNextNetwork.Text = "Next";
            this.buttonNextNetwork.UseVisualStyleBackColor = true;
            this.buttonNextNetwork.Click += new System.EventHandler(this.OnClickNext);
            // 
            // tabPageTraining
            // 
            this.tabPageTraining.Controls.Add(this.tableLayoutPanelTraining);
            this.tabPageTraining.Location = new System.Drawing.Point(4, 22);
            this.tabPageTraining.Name = "tabPageTraining";
            this.tabPageTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTraining.Size = new System.Drawing.Size(405, 235);
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
            this.tableLayoutPanelTraining.Size = new System.Drawing.Size(399, 229);
            this.tableLayoutPanelTraining.TabIndex = 1;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonNextTraining, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonStart, 0, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 196);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(393, 30);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonNextTraining
            // 
            this.buttonNextTraining.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNextTraining.Location = new System.Drawing.Point(315, 3);
            this.buttonNextTraining.Name = "buttonNextTraining";
            this.buttonNextTraining.Size = new System.Drawing.Size(75, 24);
            this.buttonNextTraining.TabIndex = 3;
            this.buttonNextTraining.Text = "Next";
            this.buttonNextTraining.UseVisualStyleBackColor = true;
            this.buttonNextTraining.Click += new System.EventHandler(this.OnClickNext);
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStart.Location = new System.Drawing.Point(234, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 24);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.OnClickStart);
            // 
            // textBoxTrainingOutput
            // 
            this.textBoxTrainingOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTrainingOutput.Location = new System.Drawing.Point(3, 3);
            this.textBoxTrainingOutput.Multiline = true;
            this.textBoxTrainingOutput.Name = "textBoxTrainingOutput";
            this.textBoxTrainingOutput.ReadOnly = true;
            this.textBoxTrainingOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTrainingOutput.Size = new System.Drawing.Size(393, 187);
            this.textBoxTrainingOutput.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanelPrediction);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(405, 235);
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
            this.tableLayoutPanelPrediction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanelPrediction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelPrediction.Size = new System.Drawing.Size(399, 229);
            this.tableLayoutPanelPrediction.TabIndex = 0;
            // 
            // buttonPredict
            // 
            this.buttonPredict.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPredict.Location = new System.Drawing.Point(321, 196);
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
            this.textBoxPredictOutput.Location = new System.Drawing.Point(3, 98);
            this.textBoxPredictOutput.Multiline = true;
            this.textBoxPredictOutput.Name = "textBoxPredictOutput";
            this.textBoxPredictOutput.ReadOnly = true;
            this.textBoxPredictOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPredictOutput.Size = new System.Drawing.Size(393, 92);
            this.textBoxPredictOutput.TabIndex = 1;
            // 
            // inputsGrid
            // 
            this.inputsGrid.AutoScroll = true;
            this.inputsGrid.CellHeight = 30F;
            this.inputsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsGrid.Location = new System.Drawing.Point(3, 3);
            this.inputsGrid.Name = "inputsGrid";
            this.inputsGrid.Size = new System.Drawing.Size(393, 89);
            this.inputsGrid.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
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
        private System.Windows.Forms.Button buttonNextNetwork;
        private System.Windows.Forms.TabPage tabPageTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonNextTraining;
        private System.Windows.Forms.Button buttonStart;
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
    }
}

