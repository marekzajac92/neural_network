using System;
using NeuralNetwork.ActivationFunctions;
using NeuralNetwork.ScalingMethods;
using System.Collections.Generic;
using NeuralNetwork.Factories;

namespace NeuralNetwork.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var scalingMethod = new AvgScalingMethod();
            scalingMethod.SetInputRange(0.0f, 255.0f);
            
            var neuronFactory = new NeuronFactory();
            var connectionFactory = new MlpConnectionFactory();
            var inputConnectionFactory = new InputConnectionFactory();
            var neurons = neuronFactory.CreateNeurons(2, 1, 0.0f, 255.0f, new LogisticActivationFunction());

            for (int i = 0; i < neurons.Length; i++)
            {
                Console.WriteLine("[{1}] - {0}", neurons[i].GetWeight(0), i);
            }

            var neurons2 = neuronFactory.CreateNeurons(2, 2, 0.0f, 1.0f, new LogisticActivationFunction());
            var connections = inputConnectionFactory.CreateConnections(2, 2, 1);
            var connections2 = connectionFactory.CreateConnections(2, 2, 2);
            var layers = new[]
            {
                new Layer(2, neurons, connections),
                new Layer(2, neurons2, connections2), 
            };


            var network = new Network(layers);

            var random = new Random();
            var inputs = new float[2];
            Console.WriteLine("Inputs");
            for (var i = 0; i < inputs.Length; i++)
            {
                inputs[i] = (float)(random.NextDouble() * 120.0f + 130.0f);
                Console.WriteLine("[{1}] - {0}", inputs[i], i);
            }

            network.SetInput(inputs);

            var output = network.GetOutput();

            foreach (var o in output)
            {
                Console.WriteLine("{0}", o);
            }

            Console.ReadLine();
        }
    }
}
