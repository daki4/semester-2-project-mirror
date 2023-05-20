using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public class ResinRefilledEventArgs : EventArgs
{
    public Resin Resin { get; }

    public ResinRefilledEventArgs(Resin resin)
    {
        Resin = resin;
    }
}
