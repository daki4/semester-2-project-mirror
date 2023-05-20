using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class BedDataReceivedEventArgs : EventArgs
{
    public Bed Bed { get; }

    public BedDataReceivedEventArgs(Bed bed)
    {
        Bed = bed;
    }
}
