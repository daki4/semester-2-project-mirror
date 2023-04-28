namespace PrinterApplication.Models;

public class Heater
{
    public bool IsOn { get; }
    
    public Heater(bool isOn)
    {
        IsOn = isOn;
    }
}
