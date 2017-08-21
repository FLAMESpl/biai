using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BIAI.Network;

namespace BIAI.Tests
{
    [TestClass]
    public class NeuronTests
    {
        [TestMethod]
        public void ActivateNeuron_ResultIsNormalizedValue()
        {
            const int repetitions = 1000;
            const int activators = 5;
            var random = new Random();

            for (int i = 0; i < repetitions; i++)
            {
                var inputLayer = new NeuronLayer(activators);
                var outputLayer = new NeuronLayer(1, inputLayer);

                inputLayer.InsertValues(random.NextArrayOfNormalizedDoubles(activators));
                outputLayer.Compute();
                Extensions.AssertIsNormalized(outputLayer.GetValues()[0]);
            }
        }
    }
}
