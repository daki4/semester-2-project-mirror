namespace PrinterApplication.Storage;
public class AccelerometeBalancedStateChangedEventArgs
{
    public bool IsLeveled { get; }

    public AccelerometeBalancedStateChangedEventArgs(bool isBalanced)
    {
        IsLeveled = isBalanced;
    }
}
