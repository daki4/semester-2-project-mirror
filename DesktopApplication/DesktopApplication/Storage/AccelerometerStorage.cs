using PrinterApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApplication.Storage;
public class AccelerometerStorage
{
    private static readonly List<Accelerometer> _accelerometer = new();
    public static event EventHandler<AccelerometerEventArgs>? OnAccelerometerDataReceived;
    public static event EventHandler<AccelerometeBalancedStateChangedEventArgs>? OnAccelerometerBalancedStateChanged;

    public static void Add(Accelerometer accelerometer) {
        _accelerometer.Add(accelerometer);
        OnAccelerometerDataReceived?.Invoke(new object(), new AccelerometerEventArgs(accelerometer));
        if (_accelerometer.SkipLast(1).Last().IsBalanced != accelerometer.IsBalanced)
        {
            OnAccelerometerBalancedStateChanged?.Invoke(new object(), new AccelerometeBalancedStateChangedEventArgs(accelerometer.IsBalanced));
        }
    }
}
