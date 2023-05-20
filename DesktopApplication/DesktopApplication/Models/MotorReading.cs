namespace PrinterApplication.Models;

public class MotorReading
{
    public int MotorId { get; }
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public MotorReading(int motorId, double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
        MotorId = motorId;
    }
}
