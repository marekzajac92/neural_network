namespace NeuralNetwork.Interfaces
{
    public interface IConnectionFactory
    {
        Connection[] CreateConnections(int numberOfValues, int numberOfNeurons, int numberOfNeuronInputs);
    }
}
