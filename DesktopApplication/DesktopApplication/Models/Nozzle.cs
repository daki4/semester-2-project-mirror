namespace PrinterApplication.Models;
public class Nozzle
{
    public double Temperature { get; }

    public bool FanIsOn { get; }

    public bool ExtruderIsOn { get; }

    public Nozzle(double temperature, bool fanIsOn, bool extruderIsOn)
    {
        Temperature = temperature;
        FanIsOn = fanIsOn;
        ExtruderIsOn = extruderIsOn;
    }
}
