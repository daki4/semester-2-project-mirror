namespace PrinterApplication.Models;

public class MotorReading
{
    public MotorId Id { get; }
    public double Position { get; }
    public MotorReading(MotorId motorId, double position)
    {
        Id = motorId;
        Position = position;
    }
}
