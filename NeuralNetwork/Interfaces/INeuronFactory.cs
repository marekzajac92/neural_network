namespace NeuralNetwork.Interfaces
{
    public interface INeuronFactory
    {
        Neuron CreateNeuron(int numberOfInputs, float minValue, float maxValue, IActivationFunction activationFunction);
        Neuron[] CreateNeurons(int numberOfInputs, float minValue, float maxValue, IActivationFunction activationFunction);
    }
}
