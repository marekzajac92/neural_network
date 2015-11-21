using System;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork.Factories
{
    public class NeuronFactory : INeuronFactory
    {
        public Neuron CreateNeuron(int numberOfInputs, float minValue, float maxValue, IActivationFunction activationFunction, Random random)
        {
            activationFunction.SetInputRange(numberOfInputs * minValue, numberOfInputs * maxValue);
            var neuron = new Neuron(numberOfInputs, activationFunction);
            for (var i = 0; i < numberOfInputs; i++)
            {
                neuron.SetWeight(i, (float)random.NextDouble());
            }

            return neuron;
        }

        public Neuron[] CreateNeurons(int numberOfNeurons, int numberOfInputs, float minValue, float maxValue, IActivationFunction activationFunction)
        {
            var neurons = new Neuron[numberOfNeurons];
            var random = new Random();
            for (var i = 0; i < numberOfNeurons; i++)
            {
                neurons[i] = CreateNeuron(numberOfInputs, minValue, maxValue, activationFunction, random);
            }

            return neurons;
        }
    }
}
