namespace PrinterApplication.Models;

public class Temperature
{
    public double Reading { get; }
    public bool IsFanOn { get; }

    public Temperature(double reading, bool isFanOn = false)
    {
        Reading = reading;
        IsFanOn = isFanOn;
    }
    
    public override string ToString()
    {
        return $"Reading: {Reading}, IsFanOn: {IsFanOn}";
    }
}
