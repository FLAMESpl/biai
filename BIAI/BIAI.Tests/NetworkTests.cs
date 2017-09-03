using BIAI.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BIAI.Tests
{
    [TestClass]
    public class NetworkTests
    {
        [TestMethod]
        public void InitializesNetwork_AllNeuronsProperlyAccessible()
        {
            var expectedLayersCount = 3;
            var network = new NeuralNetwork(3, 4, 2);

            for (int i = 0; i < expectedLayersCount - 1; i++)
            {
                var previousLayer = network.NeuronLayers[i];
                var nextLayer = network.NeuronLayers[i + 1];

                foreach (var neuron in previousLayer.Neurons)
                {
                    Assert.AreEqual(neuron.Outputs.Count, nextLayer.Neurons.Length);
                    
                    foreach (var output in neuron.Outputs.Keys)
                    {
                        Assert.IsTrue(nextLayer.Neurons.Contains(output));
                        Assert.IsTrue(output.Activators.Keys.Contains(neuron));
                    }
                }

                foreach (var neuron in nextLayer.Neurons)
                {
                    Assert.IsTrue(neuron.Activators.Keys.Contains(previousLayer.Bias));
                    Assert.AreEqual(neuron.Activators.Count, previousLayer.Neurons.Length + 1);
                }
            }
        }
    }
}
