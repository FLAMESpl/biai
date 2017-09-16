namespace BIAI.Interface.Prediction
{
    public interface IInputProvider
    {
        string InputName { get; }

        object GetInputValue();
    }
}
