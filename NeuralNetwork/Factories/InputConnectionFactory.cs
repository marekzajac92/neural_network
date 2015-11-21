using System.Collections.Generic;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork.Factories
{
    public class InputConnectionFactory : IConnectionFactory
    {
        public Connection[] CreateConnections(int numberOfValues, int numberOfNeurons, int numberOfNeuronInputs)
        {
            var connections = new List<Connection>();

            for (var i = 0; i < numberOfNeurons; i++)
            {
                connections.Add(new Connection
                {
                    Value = i,
                    Neuron = i,
                    NeuronInput = 0
                });
            }

            return connections.ToArray();
        }
    }
}
