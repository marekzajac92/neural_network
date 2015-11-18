﻿using System;
using System.Collections.Generic;
using System.Linq;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork
{
    public class Layer
    {
        private readonly int _numberOfInputs;
        private readonly Neuron[] _neurons;
        private readonly IEnumerable<Connection> _connections;
        private readonly IScalingMethod _scalingMethod;

        public Layer(int numberOfInputs, Neuron[] neurons, IEnumerable<Connection> connections, IScalingMethod scalingMethod)
        {
            _numberOfInputs = numberOfInputs;
            _neurons = neurons;

            _connections = connections;
            _scalingMethod = scalingMethod;
        }

        public void SetInput(float[] values)
        {
            if(values.Length != _numberOfInputs)
                throw new ArgumentException();

            for (var i = 0; i < values.Length; i++)
            {
                var connections = _connections.Where(x => x.Value == i);

                foreach (var connection in connections)
                {
                    _neurons[connection.Neuron].SetInputValue(connection.NeuronInput, _scalingMethod.Scale(values[i]));
                }
            }
        }

        public float[] GetOutput()
        {
            var output = _neurons.Select(x => x.GetValue()).ToArray();

            return output;
        }

        public int GetNumberOfInputs()
        {
            return _numberOfInputs;
        }

        public int GetNumberOfOutputs()
        {
            return _neurons.Length;
        }
    }
}
