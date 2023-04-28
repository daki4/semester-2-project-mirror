namespace PrinterApplication.Storage;
public class AccelerometeBalancedStateChangedEventArgs
{
    public bool IsBalanced { get; }

    public AccelerometeBalancedStateChangedEventArgs(bool isBalanced)
    {
        IsBalanced = isBalanced;
    }
}
