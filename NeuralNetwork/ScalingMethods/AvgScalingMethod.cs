using System.Runtime.InteropServices.ComTypes;
using NeuralNetwork.Interfaces;

namespace NeuralNetwork.ScalingMethods
{
    public class AvgScalingMethod : IScalingMethod
    {
        private float _a;
        private float _b;

        public void SetInputRange(float a, float b)
        {
            _a = a;
            _b = b;
        }

        public float Scale(float x)
        {
            return x;
             //return x/((_b - _a)/2.0f);
        }
    }
}
