using PrinterApplication.Models;

namespace PrinterApplication.Storage;
public static class FanStatusStorage
{
    private static List<FanStatus> _fanStatuses = new();
    public static event EventHandler<FanStatusChangedEventArgs>? OnFanStatusChanged;
    public static void Add(FanStatus fanStatus)
    {
        OnFanStatusChanged?.Invoke(new object(), new(fanStatus));
        _fanStatuses.Add(fanStatus);
    }
    public static List<FanStatus> Get()
    {
        return _fanStatuses;
    }
}
