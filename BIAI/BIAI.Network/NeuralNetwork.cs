using System;
using System.Collections.Generic;
using System.Linq;

namespace BIAI.Network
{
    public class NeuralNetwork
    {
        private NeuronLayer inputLayer => neuronLayers[0];
        private NeuronLayer hiddenLayer => neuronLayers[1];
        private NeuronLayer outputLayer => neuronLayers[2];
        private NeuronLayer[] neuronLayers = new NeuronLayer[3];

        public NeuralNetwork(int inputLayerNeuronsCount, int hiddenLayerNeuronsCount, int outputLayerNeuronsCount)
        {
            neuronLayers[0] = new NeuronLayer(inputLayerNeuronsCount);
            neuronLayers[1] = new NeuronLayer(hiddenLayerNeuronsCount, inputLayer);
            neuronLayers[2] = new NeuronLayer(outputLayerNeuronsCount, hiddenLayer);
        }

        public double[] Predict(double[] values)
        {
            if (values.Length != inputLayer.Neurons.Length)
                throw new ArgumentException("Number of input values must match number of input neurons.", nameof(values));

            inputLayer.InsertValues(values);
            hiddenLayer.Compute();
            outputLayer.Compute();

            return outputLayer.GetValues();
        }

        public void Train(IReadOnlyCollection<TrainingDataSet> trainingDataSets, double learningRate, double learningDataPercentage)
        {
            if (learningDataPercentage > 1 || learningDataPercentage < 0)
                throw new ArgumentException("Percentage of training data must be a value between 0 and 1.", nameof(learningDataPercentage));

            foreach (var dataSet in trainingDataSets)
            {
                if (dataSet.Inputs.Length != inputLayer.Neurons.Length)
                    throw new ArgumentException($"Data set's number of input values ({dataSet.Inputs.Length}) does not match size of input layer ({inputLayer.Neurons.Length})", nameof(trainingDataSets));
                
                if (dataSet.Outputs.Length != outputLayer.Neurons.Length)
                    throw new ArgumentException($"Data set's number of output values ({dataSet.Outputs.Length}) does not match size of output layer ({outputLayer.Neurons.Length})", nameof(trainingDataSets));
            }

            var learningDataCount = (int)Math.Floor(trainingDataSets.Count * learningDataPercentage);
            foreach (var dataSet in trainingDataSets.Skip(learningDataCount))
            {
                inputLayer.InsertValues(dataSet.Inputs);
                hiddenLayer.Compute();
                outputLayer.Compute();
                
                outputLayer.ComputeDelta(dataSet.Outputs);
                hiddenLayer.ComputeDelta();
                inputLayer.ComputeDelta();

                hiddenLayer.UpdateWeights(learningRate);
                outputLayer.UpdateWeights(learningRate);
            }
        }
    }
}
