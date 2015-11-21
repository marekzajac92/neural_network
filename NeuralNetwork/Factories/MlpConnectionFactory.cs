using System.Collections.Generic;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork.Factories
{
    public class MlpConnectionFactory : IConnectionFactory
    {
        public Connection[] CreateConnections(int numberOfValues, int numberOfNeurons, int numberOfNeuronInputs)
        {
            var connections = new List<Connection>();

            for (int neuron = 0; neuron < numberOfNeurons; neuron++)
            {
                for (int value = 0; value < numberOfValues; value++)
                {
                    connections.Add(new Connection
                    {
                        Neuron = neuron,
                        NeuronInput = value,
                        Value = value
                    });
                }
            }

            return connections.ToArray();
        }
    }
}
