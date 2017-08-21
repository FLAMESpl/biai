using System;
using System.Collections.Generic;

namespace BIAI.Network
{
    public class Neuron
    {
        private Dictionary<Neuron, double> activators = new Dictionary<Neuron, double>();
        private Dictionary<Neuron, double> outputs = new Dictionary<Neuron, double>();

        public double Bias { get; set; }
        public double Delta { get; set; }
        public double Value { get; set; }

        public void AddActivator(Neuron neuron, double weigth)
        {
            activators.Add(neuron, weigth);
            neuron.outputs.Add(this, weigth);
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

        public void ComputeDelta()
        {
            var error = 0d;
            foreach (var output in outputs)
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
            foreach (var activator in activators.Keys)
            {
                var weigthDelta = learningRate * Delta * activator.Value;
                activators[activator] += weigthDelta;
                activator.outputs[this] += weigthDelta;
            }
            Bias += learningRate * Delta;
        }
    }
}
