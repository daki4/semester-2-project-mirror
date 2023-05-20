namespace PrinterApplication.Models;
public class Bed
{
    public double Temperature { get; }

    public bool FanIsOn { get; }

    public bool HeaterIsOn { get; }

    public Bed(double temperature, bool fanIsOn, bool heaterIsOn)
    {
        Temperature = temperature;
        FanIsOn = fanIsOn;
        HeaterIsOn = heaterIsOn;
    }
}
