namespace PrinterApplication.Models;
public class ChassisEnvironment
{
    public double Temperature { get; }

    public bool DoorIsClosed { get; }

    public double RelativeHumidity { get; }

    public ChassisEnvironment(double temperature, bool doorIsOpen, double relativeHumidity)
    {
        Temperature = temperature;
        DoorIsClosed = doorIsOpen;
        RelativeHumidity = relativeHumidity;
    }
}
