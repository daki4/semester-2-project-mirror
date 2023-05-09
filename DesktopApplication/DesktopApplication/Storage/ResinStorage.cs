using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class ResinStorage
{
    private static readonly List<Resin> _resin = new();
    public static event EventHandler<ResinReceivedEventArgs> ResinReceived;
    public static event EventHandler<ResinLevelLowEventArgs> ResinLevelLow;
    public static event EventHandler<ResinRefilledEventArgs> ResinRefilled;

    public static void Add(Resin resin)
    {
        _resin.Add(resin);
        ResinLevelLow?.Invoke(new object(), new(resin));
        if (resin.IsLow)
        {
            ResinReceived?.Invoke(new object(), new(resin));
        }
        if (resin.Level > _resin.SkipLast(1).Last().Level)
        {
            ResinRefilled?.Invoke(new object(), new(resin));
        }
    }

    public static IReadOnlyCollection<Resin> Resin => _resin;
}
