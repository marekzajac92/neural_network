namespace NeuralNetwork.Interfaces
{
    public interface IActivationFunctionFactory
    {
        IActivationFunction CreateActivationFunction(ActivationFunction activationFunction);
    }
}
