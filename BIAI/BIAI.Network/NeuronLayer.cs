using System;
using System.Linq;

namespace BIAI.Network
{
    public class NeuronLayer
    {
        public Neuron[] Neurons { get; }

        public NeuronLayer(int size, NeuronLayer activatorsLayer = null)
        {
            Neurons = new Neuron[size];
            for (int i = 0; i < size; i++)
            {
                var random = new Random();
                var neuron = new Neuron();
                neuron.Bias = random.NextNormalizedDouble();
                if (activatorsLayer != null)
                {
                    foreach (var activator in activatorsLayer.Neurons)
                    {
                        neuron.AddActivator(activator, random.NextNormalizedDouble());
                    }
                }
                Neurons[i] = neuron;
            }
        }

        public void InsertValues(double[] values)
        {
            for (int i = 0; i < Neurons.Length; i++)
            {
                Neurons[i].Value = values[i];
            }
        }

        public void Compute()
        {
            foreach (var neuron in Neurons)
            {
                neuron.Compute();
            }
        }

        public double[] GetValues()
        {
            return Neurons.Select(n => n.Value).ToArray();
        }

        public double GetError(double[] expectedOutput)
        {
            var error = 0d;
            for (int i = 0; i < Neurons.Length; i++)
            {
                error += Math.Pow((expectedOutput[i] - Neurons[i].Value), 2);
            }
            return error;
        }

        public double GetDelta(double[] expectedOutputs)
        {
            var delta = 0d;
            for (int i = 0; i < Neurons.Length; i++)
            {
                var value = Neurons[i].Value;
                delta += (expectedOutputs[i] - value) * value * (1 - value);
            }
            return delta;
        }
    }
}
