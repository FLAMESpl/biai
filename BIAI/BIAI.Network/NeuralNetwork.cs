﻿using BIAI.Network.Events;
using System;
using System.Collections.Generic;

namespace BIAI.Network
{
    public class NeuralNetwork
    {
        public event EventHandler<TrainingEpochCompletedEventArgs> TrainingEpochCompleted;

        private NeuronLayer[] neuronLayers = new NeuronLayer[3];
        private Random random = new Random();

        public NeuronLayer InputLayer => neuronLayers[0];
        public NeuronLayer HiddenLayer => neuronLayers[1];
        public NeuronLayer OutputLayer => neuronLayers[2];
        public IReadOnlyList<NeuronLayer> NeuronLayers { get; private set; }

        public NeuralNetwork(int inputLayerNeuronsCount, int hiddenLayerNeuronsCount, int outputLayerNeuronsCount)
        {
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

        public void Train(IReadOnlyList<TrainingDataSet> trainingDataSets, double learningRate, double learningDataPercentage, int epochs)
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
            
            var order = new int[trainingDataSets.Count];
            for (int i = 0; i < order.Length; i++)
                order[i] = i;

            var learningDataCount = (int)Math.Floor(trainingDataSets.Count * learningDataPercentage);

            for (int epoch = 0; epoch < epochs; epoch++)
            {
                Shuffle(order);

                for (int i = 0; i < learningDataCount; i++)
                {
                    var index = order[i];

                    InputLayer.InsertValues(trainingDataSets[index].Inputs);
                    HiddenLayer.Compute();
                    OutputLayer.Compute();

                    OutputLayer.ComputeDelta(trainingDataSets[index].Outputs);
                    HiddenLayer.ComputeDelta();
                    InputLayer.ComputeDelta();

                    HiddenLayer.UpdateWeights(learningRate);
                    OutputLayer.UpdateWeights(learningRate);
                }

                var totalCorrect = 0;
                for (int i = learningDataCount; i < trainingDataSets.Count; i++)
                {
                    var index = order[i];
                    var outcome = Predict(trainingDataSets[index].Inputs);

                    if (outcome.MaxIndex() == trainingDataSets[index].Outputs.MaxIndex())
                        totalCorrect++;
                }

                var accuracy = (double)totalCorrect / (trainingDataSets.Count - learningDataCount);
                TrainingEpochCompleted?.Invoke(this, new TrainingEpochCompletedEventArgs(epoch, accuracy));
            }
        }

        private void Shuffle(int[] order)
        {
            for (int i = 0; i < order.Length; i++)
            {
                int r = random.Next(i, order.Length);
                int tmp = order[r];
                order[r] = order[i];
                order[i] = tmp;
            }
        }
    }
}
