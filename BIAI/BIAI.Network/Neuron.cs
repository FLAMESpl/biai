using System;
using System.Collections.Generic;

namespace BIAI.Network
{
    public class Neuron
    {
        private Dictionary<Neuron, double> activators = new Dictionary<Neuron, double>();
        
        public double Bias { get; set; }
        public double Value { get; set; }

        public void AddActivator(Neuron neuron, double weigth)
        {
            activators.Add(neuron, weigth);
        }

        public void Compute()
        {
            var inputsSum = Bias;
            foreach (var connection in activators)
            {
                inputsSum += connection.Key.Value * connection.Value;
            }

            Value = 1d / (Math.Exp(inputsSum) + 1);
        }
    }
}
