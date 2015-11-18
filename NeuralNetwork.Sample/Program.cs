using NeuralNetwork.ActivationFunctions;
using NeuralNetwork.ScalingMethods;
using System.Collections.Generic;

namespace NeuralNetwork.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var activationFunction = new LogisticActivationFunction();
            activationFunction.SetInputRange(0.0f, 255.0f * 2);
            var scalingMethod = new AvgScalingMethod();
            scalingMethod.SetInputRange(0.0f, 255.0f);
            var neurons = new[]
            {
                new Neuron(2, activationFunction),
                new Neuron(2, activationFunction)
            };
            neurons[0].SetWeight(0, 0.5f);
            neurons[0].SetWeight(1, 0.25f);
            neurons[1].SetWeight(0, 0.15f);
            neurons[1].SetWeight(1, 0.55f);

            var connections = new List<Connection>();
            connections.Add(new Connection()
            {
                Value = 0,
                Neuron = 0,
                NeuronInput = 0
            });
            connections.Add(new Connection()
            {
                Value = 1,
                Neuron = 0,
                NeuronInput = 1
            });
            connections.Add(new Connection()
            {
                Value = 0,
                Neuron = 1,
                NeuronInput = 0
            });
            connections.Add(new Connection()
            {
                Value = 1,
                Neuron = 1,
                NeuronInput = 1
            });
            var layers = new[] {new Layer(2, neurons, connections, scalingMethod)};

            var network = new Network(layers);

            network.SetInput(new [] { 22.0f, 145.0f});

            var output = network.GetOutput();
        }
    }
}
