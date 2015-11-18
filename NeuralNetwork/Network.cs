using System;
using System.Linq;

namespace NeuralNetwork
{
    public class Network
    {
        private readonly Layer[] _layers;

        public Network(Layer[] layers)
        {
            _layers = layers;
        }

        public void SetInput(float[] values)
        {
            _layers.First().SetInput(values);
        }

        public float[] GetOutput()
        {
            var output = new float[_layers[0].GetNumberOfOutputs()];
            for(var i = 0; i < _layers.Length; i++)
            {
                if(i > 0)
                    _layers[i].SetInput(output);
                output = _layers[i].GetOutput();
            }

            return output;
        }
    }
}
