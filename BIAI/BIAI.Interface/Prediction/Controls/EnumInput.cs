using System;
using System.Reflection;
using System.Windows.Forms;

namespace BIAI.Interface.Prediction.Controls
{
    public partial class EnumInput : ComboBox, IInputProvider
    {
        private Type type;

        public string InputName { get; private set; }
        public bool IsNullable { get; private set; }

        public EnumInput(string name, Type type, bool isNullable)
        {
            InitializeComponent();

            InputName = name;
            this.type = type;

            if (type.IsEnum)
            {
                foreach (var value in Enum.GetValues(type))
                {
                    Items.Add(value.ToString());
                }
            }
            else if (type == typeof(bool))
            {
                Items.Add("True");
                Items.Add("False");
            }
            else
                throw new ArgumentException("Type must be either bool or enum.");
        }

        public object GetInputValue()
        {
            if (type == typeof(bool))
            {
                switch (SelectedIndex)
                {
                    case 0: return true;
                    case 1: return false;
                    default: return null;
                }
            }
            else
            {
                return Enum.Parse(type, (string)Items[SelectedIndex]);
            }
        }
    }
}
