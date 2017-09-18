﻿using System.Collections.Generic;
using System.Windows.Forms;
using BIAI.Interface.Columns;
using System.Reflection;
using System.Linq;
using System;
using BIAI.Data.Model.Annotations;

namespace BIAI.Interface.Prediction.Controls
{
    public partial class InputsGrid : UserControl
    {
        private List<IInputProvider> inputProviders;

        public float CellHeight { get; set; } = 30;

        public InputsGrid()
        {
            InitializeComponent();
        }
        
        public void SetColumns(IReadOnlyList<ColumnSetting> columns)
        {
            inputProviders = new List<IInputProvider>();
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();

            int longestLabel = 0;

            for (int i = 0; i < columns.Count; i++)
            {
                var label = new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Text = columns[i].Name
                };

                var textLength = columns[i].Name.Length * 10;

                if (textLength > longestLabel)
                    longestLabel = textLength;

                var input = CreateInput(columns[i].PropertyInfo);
                inputProviders.Add(input as IInputProvider);
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, CellHeight));
                tableLayoutPanel.Controls.Add(label, 0, i);
                tableLayoutPanel.Controls.Add(input, 1, i);
            }

            tableLayoutPanel.ColumnStyles[0].Width = longestLabel;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            tableLayoutPanel.AutoSize = true;
        }

        public object[] GetValues()
        {
            return inputProviders?.Select(x => x.GetInputValue()).ToArray();
        }

        private Control CreateInput(PropertyInfo propertyInfo)
        {
            var type = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
            var nullable = type != null;
            if (!nullable)
                type = propertyInfo.PropertyType;

            var dictionaryData = propertyInfo.GetCustomAttribute<Dictionary>();
            if (dictionaryData != null)
                return new DictionaryInput(propertyInfo.Name, dictionaryData);

            if (type == typeof(int) || type == typeof(long))
                return new NumberInput(propertyInfo.Name);

            if (type == typeof(bool) || type.IsEnum)
                return new EnumInput(propertyInfo.Name, type);

            throw new InvalidOperationException("Unrecognized input type.");
        }
    }
}
