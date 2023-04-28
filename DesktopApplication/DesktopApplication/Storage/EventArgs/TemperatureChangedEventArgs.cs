using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class TemperatureChangedEventArgs : EventArgs
{
    public Temperature Temperature { get; }
    public TemperatureChangedEventArgs(Temperature temperature)
    {
        Temperature = temperature;
    }
}
