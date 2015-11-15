using System;
using System.Linq;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork
{
    public class Neuron
    {
        private readonly int _numberOfInputs;
        private readonly float[] _inputs;
        private readonly float[] _weights;
        private readonly IActivationFunction _activationFunction;

        public Neuron(int numberOfInputs, IActivationFunction activationFunction)
        {
            _numberOfInputs = numberOfInputs;
            _activationFunction = activationFunction;
            
            _inputs = new float[numberOfInputs];
            _weights = new float[numberOfInputs];
        }

        public void SetInputValue(int i, float value)
        {
            if(i >= _numberOfInputs || i < 0)
                throw new ArgumentOutOfRangeException();

            _inputs[i] = value;
        }

        public void SetWeight(int i, float value)
        {
            if(i >= _numberOfInputs || i < 0)
                throw new ArgumentOutOfRangeException();

            _weights[i] = value;
        }

        public float GetInputValue(int i)
        {
            if(i >= _numberOfInputs || i < 0)
                throw new ArgumentOutOfRangeException();

            return _inputs[i];
        }

        public float GetWeight(int i)
        {
            if (i >= _numberOfInputs || i < 0)
                throw new ArgumentOutOfRangeException();

            return _weights[i];
        }

        public float GetMaxValue()
        {
            throw new NotImplementedException();
        }

        public float GetMinValue()
        {
            throw new NotImplementedException();
        }

        public float GetValue()
        {
            var sum = SumInputs();
            var weightsSum = SumWeights();

            return _activationFunction.GetValue(sum, weightsSum);
        }

        private float SumInputs()
        {
            var sum = 0.0f;
            for (var i = 0; i < _numberOfInputs; i++)
            {
                sum += _inputs[i]*_weights[i];
            }

            return sum;
        }

        private float SumWeights()
        {
            return _weights.Sum();
        }
    }
}
