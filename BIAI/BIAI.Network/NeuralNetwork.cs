using System;
using System.Collections.Generic;

namespace BIAI.Network
{
    public class NeuralNetwork
    {
        private NeuronLayer[] neuronLayers = new NeuronLayer[3];

        public NeuronLayer InputLayer => neuronLayers[0];
        public NeuronLayer HiddenLayer => neuronLayers[1];
        public NeuronLayer OutputLayer => neuronLayers[2];
        public IReadOnlyList<NeuronLayer> NeuronLayers { get; private set; }

        public double Accuracy { get; private set; }

        public NeuralNetwork(int inputLayerNeuronsCount, int hiddenLayerNeuronsCount, int outputLayerNeuronsCount)
        {
            //System.Diagnostics.Debugger.Break();

            neuronLayers[0] = new NeuronLayer(inputLayerNeuronsCount);
            neuronLayers[1] = new NeuronLayer(hiddenLayerNeuronsCount, InputLayer);
            neuronLayers[2] = new NeuronLayer(outputLayerNeuronsCount, HiddenLayer);

            NeuronLayers = Array.AsReadOnly(neuronLayers);
        }

        public double[] Predict(double[] values)
        {
            if (values.Length != InputLayer.Neurons.Length)
                throw new ArgumentException("Number of input values must match number of input neurons.", nameof(values));

            InputLayer.InsertValues(values);
            HiddenLayer.Compute();
            OutputLayer.Compute();

            return OutputLayer.GetValues();
        }

        public void Train(IReadOnlyList<TrainingDataSet> trainingDataSets, double learningRate, double learningDataPercentage)
        {
            if (learningDataPercentage > 1 || learningDataPercentage < 0)
                throw new ArgumentException("Percentage of training data must be a value between 0 and 1.", nameof(learningDataPercentage));

            foreach (var dataSet in trainingDataSets)
            {
                if (dataSet.Inputs.Length != InputLayer.Neurons.Length)
                    throw new ArgumentException($"Data set's number of input values ({dataSet.Inputs.Length}) does not match size of input layer ({InputLayer.Neurons.Length})", nameof(trainingDataSets));
                
                if (dataSet.Outputs.Length != OutputLayer.Neurons.Length)
                    throw new ArgumentException($"Data set's number of output values ({dataSet.Outputs.Length}) does not match size of output layer ({OutputLayer.Neurons.Length})", nameof(trainingDataSets));
            }
            
            var learningDataCount = (int)Math.Floor(trainingDataSets.Count * learningDataPercentage);

            for (int i = 0; i < learningDataCount; i++)
            {
                InputLayer.InsertValues(trainingDataSets[i].Inputs);
                HiddenLayer.Compute();
                OutputLayer.Compute();

                OutputLayer.ComputeDelta(trainingDataSets[i].Outputs);
                HiddenLayer.ComputeDelta();
                InputLayer.ComputeDelta();

                HiddenLayer.UpdateWeights(learningRate);
                OutputLayer.UpdateWeights(learningRate);
            } 

            var total = 0d;
            for (int i = learningDataCount; i < trainingDataSets.Count; i++)
            {
                var outcome = Predict(trainingDataSets[i].Inputs);

                for (int j = 0; j < outcome.Length; j++)
                {
                    total += Math.Abs(trainingDataSets[i].Outputs[j] + outcome[j]) / 2;
                }
            }

            Accuracy = total / ((trainingDataSets.Count - learningDataCount) * OutputLayer.Neurons.Length);
        }
    }
}
