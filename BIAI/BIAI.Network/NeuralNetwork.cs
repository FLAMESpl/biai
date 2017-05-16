﻿using System;
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

        public double[] Process(double[] values)
        {
            if (values.Length != inputLayer.Neurons.Length)
                throw new ArgumentException("Number of input values must match number of input neurons.", nameof(values));

            inputLayer.InsertValues(values);
            foreach (var layer in neuronLayers.Skip(1))
            {
                layer.Compute();
            }

            return outputLayer.GetValues();
        }

        public double Train(double[][] dataSet, double trainingDataPercentage)
        {
            if (trainingDataPercentage > 1 || trainingDataPercentage < 0)
                throw new ArgumentException("Percentage of training data must be a value between 0 and 1.", nameof(trainingDataPercentage));

            return 0;
        }
    }
}