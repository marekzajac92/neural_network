using System;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork.ActivationFunctions
{
    public class LogisticActivationFunction : IActivationFunction
    {
        private float _a;
        private float _b;

        public float GetValue(float x, float weightsSum)
        {
            var oldMin = _a*weightsSum;
            var oldMax = _b*weightsSum;

            var p = ((x - oldMin) - (1.0f - 0.0f))/(oldMax - oldMin);

            var value = 1.0f/(1.0f + Math.Exp(-0.5f*p));

            return (float)value;
        }

        public void SetInputRange(float a, float b)
        {
            _a = a;
            _b = b;
        }
    }
}
