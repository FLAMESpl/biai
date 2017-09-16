using System;

namespace BIAI.Interface.Prediction
{
    public class InputValueException : Exception
    {
        public InputValueException(string message) : base(message)
        {
        }
    }
}
