using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class AccelerometerStorage
{
    private static readonly List<Accelerometer> _accelerometer = new();
    public static event EventHandler<AccelerometerEventArgs>? OnAccelerometerDataReceived;
    public static event EventHandler<AccelerometeBalancedStateChangedEventArgs>? OnAccelerometerBalancedStateChanged;

    // TODO: use this method and debug this method
    public static void Add(Accelerometer accelerometer)
    {
        _accelerometer.Add(accelerometer);
        OnAccelerometerDataReceived?.Invoke(new object(), new(accelerometer));
        if (_accelerometer.SkipLast(1).Last().IsBalanced != accelerometer.IsBalanced)
        {
            OnAccelerometerBalancedStateChanged?.Invoke(new object(), new(accelerometer.IsBalanced));
        }
    }
}
