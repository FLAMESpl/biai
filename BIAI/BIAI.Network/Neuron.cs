using System;
using System.Collections.Generic;
using System.Linq;

namespace BIAI.Network
{
    public class Neuron : INeuron
    {
        public IDictionary<INeuron, double> Activators { get; } = new Dictionary<INeuron, double>();
        public IDictionary<INeuron, double> Outputs { get; } = new Dictionary<INeuron, double>();
        
        public double Delta { get; set; }
        public double Value { get; set; }

        public void AddActivator(INeuron neuron, double weigth)
        {
            Activators.Add(neuron, weigth);
            neuron.Outputs.Add(this, weigth);
        }

        public void Compute()
        {
            var inputsSum = 0d;
            foreach (var connection in Activators)
            {
                inputsSum += connection.Key.Value * connection.Value;
            }
            Value = 1d / (Math.Exp(inputsSum) + 1);
        }

        public void ComputeDelta()
        {
            var error = 0d;
            foreach (var output in Outputs)
            {
                error += output.Value * output.Key.Delta;
            }
            Delta = error * Value * (1 - Value);
        }

        public void ComputeDelta(double expectedValue)
        {
            Delta = (expectedValue - Value) * Value * (1 - Value);
        }

        public void UpdateWeigths(double learningRate)
        {
            foreach (var activator in Activators.Keys.ToList())
            {
                var weigthDelta = learningRate * Delta * activator.Value;
                Activators[activator] += weigthDelta;
                activator.Outputs[this] += weigthDelta;
            }
        }
    }
}
