namespace NeuralNetwork.Interfaces
{
    public interface ILayerFactory
    {
        Layer CreateLayer(int numberOfInputs, Neuron[] neurons, LayerType layerType);
    }
}
