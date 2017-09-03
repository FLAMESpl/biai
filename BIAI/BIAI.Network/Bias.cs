using System.Collections.Generic;

namespace BIAI.Network
{
    public class Bias : INeuron
    {
        public IDictionary<INeuron, double> Activators { get; } = new Dictionary<INeuron, double>();
        public IDictionary<INeuron, double> Outputs { get; } = new Dictionary<INeuron, double>();

        public double Delta { get; set; }
        public double Value => 1;

        public void ComputeDelta()
        {
            var error = 0d;
            foreach (var output in Outputs)
            {
                error += output.Value * output.Key.Delta;
            }
            Delta = error * Value * (1 - Value);
        }
    }
}
