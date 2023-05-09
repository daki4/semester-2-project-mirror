using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class AccelerometerEventArgs
{
    public Accelerometer Accelerometer { get; }

    public AccelerometerEventArgs(Accelerometer accelerometer)
    {
        Accelerometer = accelerometer;
    }
}
