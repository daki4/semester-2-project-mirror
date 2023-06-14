namespace PrinterApplication.Models;

public class Accelerometer
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }
    public bool IsLeveled { get; }

    public Accelerometer(double x, double y, double z, bool isLeveled)
    {
        X = x;
        Y = y;
        Z = z;
        IsLeveled = isLeveled;
    }
}
