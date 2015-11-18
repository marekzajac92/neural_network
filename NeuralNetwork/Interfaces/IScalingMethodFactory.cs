namespace NeuralNetwork.Interfaces
{
    public interface IScalingMethodFactory
    {
        IScalingMethod CreateScalingMethod(ScalingMethod scalingMethod);
    }
}
