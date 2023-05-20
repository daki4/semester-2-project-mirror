using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class ResinStorage
{
    private static readonly List<Resin> _resin = new();
    public static event EventHandler<ResinReceivedEventArgs>? ResinReceived;
    public static event EventHandler<ResinLevelLowEventArgs>? ResinLevelLow;
    public static event EventHandler<ResinRefilledEventArgs>? ResinRefilled;

    public static void Add(Resin resin)
    {
        _resin.Add(resin);
        ResinReceived?.Invoke(new(), new(resin));
        if (resin.IsLow)
        {
            ResinLevelLow?.Invoke(new(), new(resin));
        }
        if (resin.Level > _resin.SkipLast(1).Last().Level)
        {
            ResinRefilled?.Invoke(new(), new(resin));
        }
    }

    public static IReadOnlyCollection<Resin> Resin => _resin;
}
