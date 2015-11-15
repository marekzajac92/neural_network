namespace NeuralNetwork.Interfaces
{
    public interface IScalingMethod
    {
        void SetInputRange(float a, float b);
        float Scale(float x);
    }
}
