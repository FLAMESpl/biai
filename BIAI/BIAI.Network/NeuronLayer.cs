using System;
using System.Linq;

namespace BIAI.Network
{
    public class NeuronLayer
    {
        public Neuron[] Neurons { get; }
        public Bias Bias { get; }

        public NeuronLayer(int size, NeuronLayer activatorsLayer = null)
        {
            Neurons = new Neuron[size];
            Bias = new Bias();
            var random = new Random();

            for (int i = 0; i < size; i++)
            {
                var neuron = new Neuron();

                if (activatorsLayer != null)
                {
                    foreach (var activator in activatorsLayer.Neurons)
                    {
                        neuron.AddActivator(activator, random.NextNormalizedDouble());
                    }

                    neuron.AddActivator(activatorsLayer.Bias, random.NextNormalizedDouble());
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

        public void ComputeDelta()
        {
            foreach (var neuron in Neurons)
            {
                neuron.ComputeDelta();
            }
            Bias.ComputeDelta();
        }

        public void ComputeDelta(double[] expectedValues)
        {
            for (int i = 0; i < Neurons.Length; i++)
            {
                Neurons[i].ComputeDelta(expectedValues[i]);
            }
        }

        public void UpdateWeights(double learningRate, double weightDecay, double momentum)
        {
            foreach (var neuron in Neurons)
            {
                neuron.UpdateWeigths(learningRate, weightDecay, momentum);
            }

            // Bias has no activator therefore no need to call update weigths function
        }
    }
}
