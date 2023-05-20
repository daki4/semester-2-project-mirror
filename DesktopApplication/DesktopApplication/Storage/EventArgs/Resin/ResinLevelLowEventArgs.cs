using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public class ResinLevelLowEventArgs : EventArgs
{
    public Resin Resin { get; }

    public ResinLevelLowEventArgs(Resin resin)
    {
        Resin = resin;
    }
}
