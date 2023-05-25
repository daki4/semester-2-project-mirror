using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class MotorStorage
{
    private static readonly List<MotorReading> _motor = new();
    public static IReadOnlyCollection<MotorReading> _motorX = _motor.Where(motor => motor.Id == MotorId.X).ToList().AsReadOnly();
    public static IReadOnlyCollection<MotorReading> _motorY = _motor.Where(motor => motor.Id == MotorId.Y).ToList().AsReadOnly();
    public static IReadOnlyCollection<MotorReading> _motorZ = _motor.Where(motor => motor.Id == MotorId.Z).ToList().AsReadOnly();

    public static event EventHandler<MotorEventArgs>? OnMotorXDataReceived;
    public static event EventHandler<MotorEventArgs>? OnMotorYDataReceived;
    public static event EventHandler<MotorEventArgs>? OnMotorZDataReceived;

    public static void Add(MotorReading motor)
    {
        _motor.Add(motor);
        _motor.Limit(1200);
        EventHandler<MotorEventArgs>? toBeCalled = motor.Id switch
        {
            MotorId.X => OnMotorXDataReceived,
            MotorId.Y => OnMotorYDataReceived,
            MotorId.Z => OnMotorZDataReceived,
            _ => null
        };
        toBeCalled?.Invoke(new(), new(motor));
    }
}
