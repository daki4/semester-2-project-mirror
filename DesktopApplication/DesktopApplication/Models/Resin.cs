namespace PrinterApplication.Models;

public class Resin
{
    private static double WARNING_LEVEL = 25;
    public double Level { get; }
    public bool IsLow { get; }

    public Resin(double level)
    {
        IsLow = level <= WARNING_LEVEL;
        Level = level;
    }
}
