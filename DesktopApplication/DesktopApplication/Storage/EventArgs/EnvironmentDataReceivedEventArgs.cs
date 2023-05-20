using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public class EnvironmentDataReceivedEventArgs : EventArgs
{
    public ChassisEnvironment Environment { get; }

    public EnvironmentDataReceivedEventArgs(ChassisEnvironment environment)
    {
        Environment = environment;
    }
}
