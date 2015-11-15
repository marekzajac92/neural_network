using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork.Tests
{
    [TestClass]
    public class NeuronTests
    {
        [TestMethod]
        public void SetInputValue_CorrectValue()
        {
            var activationFunction = new Mock<IActivationFunction>();
            var neuron = new Neuron(2, activationFunction.Object);

            neuron.SetInputValue(0, 1.0f);

            Assert.IsTrue(neuron.GetInputValue(0) > 0.99f && neuron.GetInputValue(0) < 1.01f, "Wrong input value");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetInputValue_OutOfRange()
        {
            var activationFunction = new Mock<IActivationFunction>();
            var neuron = new Neuron(2, activationFunction.Object);

            neuron.SetInputValue(3, 1.0f);
        }

        [TestMethod]
        public void SetWeight_CorrectValue()
        {
            var activationFunction = new Mock<IActivationFunction>();
            var neuron = new Neuron(2, activationFunction.Object);

            neuron.SetWeight(0, 1.0f);

            Assert.IsTrue(neuron.GetWeight(0) > 0.99f && neuron.GetWeight(0) < 1.01f, "Wrong weight");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void SetWeight_OutOfRange()
        {
            var activationFunction = new Mock<IActivationFunction>();
            var neuron = new Neuron(2, activationFunction.Object);

            neuron.SetWeight(3, 1.0f);
        }

        [TestMethod]
        public void GetValue_CorrectInput()
        {
            var activationFunction = new Mock<IActivationFunction>();
            activationFunction.Setup(x => x.GetValue(It.IsAny<float>(), It.IsAny<float>())).Returns((float x, float y) => x);
            var neuron = new Neuron(2, activationFunction.Object);

            neuron.SetInputValue(0, 1.0f);
            neuron.SetInputValue(1, 1.0f);
            neuron.SetWeight(0, 1.0f);
            neuron.SetWeight(1, 1.0f);

            var output = neuron.GetValue();

            Assert.IsTrue(output > 1.99f && output < 2.01f);
        }
    }
}
