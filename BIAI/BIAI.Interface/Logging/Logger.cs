using System;
using System.Windows.Forms;

namespace BIAI.Interface.Logging
{
    public class Logger
    {
        private Action<string> outputTarget;
        private string text = String.Empty;
        private string lastMessage = String.Empty;

        public Logger(Action<string> outputTarget)
        {
            this.outputTarget = outputTarget;
        }

        public void Message(string message)
        {
            text = $"{text}{message}{Environment.NewLine}";
            lastMessage = String.Empty;
            Update();
        }

        private void Update()
        {
            outputTarget.Invoke($"{text}{lastMessage}");
        }
    }
}
