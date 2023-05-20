using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class NozzleDataReceivedEventArgs : EventArgs
{
    public Nozzle Nozzle { get; }

    public NozzleDataReceivedEventArgs(Nozzle nozzle)
    {
        Nozzle = nozzle;
    }
}
