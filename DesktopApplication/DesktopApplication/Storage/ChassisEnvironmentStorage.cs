using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class ChassisEnvironmentStorage
{
    private static readonly List<ChassisEnvironment> _environment = new();
    public static event EventHandler<EnvironmentDataReceivedEventArgs>? ChassisEnvironmentDataReceived;
    public static event EventHandler<EnvironmentDataReceivedEventArgs>? ChassisDoorStateChanged;

    public static void Add(ChassisEnvironment environment)
    {
        _environment.Add(environment);
        _environment.Limit(100);
        ChassisEnvironmentDataReceived?.Invoke(new(), new(environment));
        if (_environment.Count == 1)
        {
            ChassisDoorStateChanged?.Invoke(new(), new(environment));
        }
        else if (_environment.SkipLast(1).Last().DoorIsClosed != environment.DoorIsClosed)
        {
            ChassisDoorStateChanged?.Invoke(new(), new(environment));
        }
    }

    public static IReadOnlyCollection<ChassisEnvironment> Environment => _environment.AsReadOnly();
}
