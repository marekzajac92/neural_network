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

            var p = (((6.0f - (-6.0f)) * (x - oldMin)) / (oldMax - oldMin)) - 5.0f;

            if (p < -45.0f) return 0.0f;
            if (p > 45.0f) return 1.0f;

            var value = 1.0f/(1.0f + Math.Exp(1.0f-p));

            return (float)value;
        }

        public void SetInputRange(float a, float b)
        {
            _a = a;
            _b = b;
        }
    }
}
