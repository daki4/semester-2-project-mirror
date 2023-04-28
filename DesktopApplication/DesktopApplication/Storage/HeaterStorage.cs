using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class HeaterStorage
{
    private static readonly List<Heater> _heater = new();
    public static event EventHandler<HeaterStateChangedEventArgs>? HeaterStateChanged;

    public static void Add(Heater heater)
    {
        _heater.Add(heater);
        HeaterStateChanged?.Invoke(new object(), new HeaterStateChangedEventArgs(heater));
    }

    public static IReadOnlyCollection<Heater> Heater => _heater.AsReadOnly();
}
