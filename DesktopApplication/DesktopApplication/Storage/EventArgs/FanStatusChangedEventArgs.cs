using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class FanStatusChangedEventArgs : EventArgs
{
    public FanStatus status { get; }
    public FanStatusChangedEventArgs(FanStatus fanStatus) : base()
    {
        status = fanStatus;
    }
}
