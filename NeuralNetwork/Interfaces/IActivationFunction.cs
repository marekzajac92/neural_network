namespace NeuralNetwork.Interfaces
{
    public interface IActivationFunction
    {
        float GetValue(float x, float weightsSum);
        void SetInputRange(float a, float b);
    }
}
