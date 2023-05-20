using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class ChassisEnvironmentStorage
{
    private static readonly List<ChassisEnvironment> _environment = new();
    public static event EventHandler<EnvironmentDataReceivedEventArgs>? ChassisEnvironmentDataReceived;

    public static void Add(ChassisEnvironment environment)
    {
        _environment.Add(environment);
        _environment.Limit(100);
        ChassisEnvironmentDataReceived?.Invoke(new(), new(environment));
    }

    public static IReadOnlyCollection<ChassisEnvironment> Environment => _environment.AsReadOnly();
}
