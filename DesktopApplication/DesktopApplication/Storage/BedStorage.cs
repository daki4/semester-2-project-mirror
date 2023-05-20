using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class BedStorage
{
    private static readonly List<Bed> _bed = new();
    public static event EventHandler<BedDataReceivedEventArgs>? BedDataReceived;

    public static void Add(Bed bed)
    {
        _bed.Add(bed);
        _bed.Limit(100);
        BedDataReceived?.Invoke(new(), new(bed));
    }

    public static IReadOnlyCollection<Bed> Bed => _bed.AsReadOnly();
}
