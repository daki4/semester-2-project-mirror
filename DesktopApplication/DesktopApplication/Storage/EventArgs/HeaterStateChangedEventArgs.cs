using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class HeaterStateChangedEventArgs : EventArgs
{
    public Heater Heater { get; }

    public HeaterStateChangedEventArgs(Heater heater)
    {
        Heater = heater;
    }
}
