namespace PrinterApplication.Models;

public class MotorReading
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public MotorReading(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}, Z: {Z}";
    }
}
