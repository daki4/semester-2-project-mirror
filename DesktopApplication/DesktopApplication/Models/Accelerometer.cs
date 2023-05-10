namespace PrinterApplication.Models;

public class Accelerometer
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }
    public bool IsBalanced { get; }

    public Accelerometer(double x, double y, double z, bool isBalanced)
    {
        X = x;
        Y = y;
        Z = z;
        IsBalanced = isBalanced;
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}, Z: {Z}";
    }
}
