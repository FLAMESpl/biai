using System;
using System.Windows.Forms;

namespace BIAI.Interface.Prediction.Controls
{
    public partial class NumberInput : TextBox, IInputProvider
    {
        public string InputName { get; set; }

        public NumberInput()
        {
            InitializeComponent();
        }

        public NumberInput(string inputName)
        {
            InitializeComponent();
            InputName = inputName;
        }

        public object GetInputValue()
        {
            long value;
            if (!long.TryParse(Text, out value))
                throw new InputValueException($"Input {InputName} must be an integral number.");

            return value;
        }
    }
}
