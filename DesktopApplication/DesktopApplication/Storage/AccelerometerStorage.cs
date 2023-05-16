using PrinterApplication.Models;
using System.Security.Cryptography.X509Certificates;

namespace PrinterApplication.Storage;
public class AccelerometerStorage
{
    private static readonly List<Accelerometer> _accelerometer = new();
    public static event EventHandler<AccelerometerEventArgs>? OnAccelerometerDataReceived;
    public static event EventHandler<AccelerometeBalancedStateChangedEventArgs>? OnAccelerometerBalancedStateChanged;

    // TODO: use this method and debug this method
    public static void Add(Accelerometer reading)
    {
        _accelerometer.Add(reading);
        OnAccelerometerDataReceived?.Invoke(new object(), new(reading));
        if (_accelerometer.SkipLast(1).Last().IsLeveled != reading.IsLeveled)
        {
            OnAccelerometerBalancedStateChanged?.Invoke(new object(), new(reading.IsLeveled));
        }
    }
    public static IReadOnlyCollection<Accelerometer> Accelerometer => _accelerometer;
}
