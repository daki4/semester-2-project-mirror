namespace PrinterApplication.Models;

public class Temperature
{
    public double Reading { get; }

    public Temperature(double reading)
    {
        Reading = reading;
    }

    public override string ToString()
    {
        return $"Reading: {Reading}";
    }
}
