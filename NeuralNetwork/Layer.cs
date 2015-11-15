using System;
using System.Collections.Generic;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork
{
    public class Layer
    {
        public Layer(int numberOfInputs, Neuron[] neurons, IEnumerable<Connection> connections, IScalingMethod scalingMethod)
        {
            throw new NotImplementedException();
        }

        public void SetInput(float[] values)
        {
            throw new NotImplementedException();
        }

        public float[] GetOutput()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfInputs()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfOutputs()
        {
            throw new NotImplementedException();
        }
    }
}
