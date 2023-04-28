using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public class ResinReceivedEventArgs : EventArgs
{
    public Resin Resin { get; }

    public ResinReceivedEventArgs(Resin resin)
    {
        Resin = resin;
    }
}
