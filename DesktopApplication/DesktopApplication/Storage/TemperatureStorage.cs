using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class TemperatureStorage
{
    private static readonly List<Temperature> _temperatures = new();
    public static event EventHandler<TemperatureChangedEventArgs>? TemperatureChanged;
    public static void Add(Temperature temperature)
    {
        _temperatures.Add(temperature);
        TemperatureChanged?.Invoke(new object(), new(temperature));
    }

    public static IReadOnlyCollection<Temperature> Temperature => _temperatures;
}