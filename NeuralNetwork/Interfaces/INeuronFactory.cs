using System;

namespace NeuralNetwork.Interfaces
{
    public interface INeuronFactory
    {
        Neuron CreateNeuron(int numberOfInputs, float minValue, float maxValue, IActivationFunction activationFunction, Random random);
        Neuron[] CreateNeurons(int numberOfNeurons, int numberOfInputs, float minValue, float maxValue, IActivationFunction activationFunction);
    }
}
