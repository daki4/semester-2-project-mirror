using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class NozzleStorage
{
    private static readonly List<Nozzle> _nozzle = new();
    public static event EventHandler<NozzleDataReceivedEventArgs>? NozzleDataReceived;
    public static event EventHandler<NozzleDataReceivedEventArgs>? NozzleFanStateChanged;
    public static event EventHandler<NozzleDataReceivedEventArgs>? NozzleExtruderStateChanged;
    public static void Add(Nozzle nozzle)
    {
        _nozzle.Add(nozzle);
        _nozzle.Limit(100);
        NozzleDataReceived?.Invoke(new(), new(nozzle));
        if (_nozzle.SkipLast(1).Last().FanIsOn != nozzle.FanIsOn)
        {
            NozzleFanStateChanged?.Invoke(new(), new(nozzle));
        }
        if (_nozzle.SkipLast(1).Last().ExtruderIsOn != nozzle.ExtruderIsOn)
        {
            NozzleExtruderStateChanged?.Invoke(new(), new(nozzle));
        }
    }

    public static IReadOnlyCollection<Nozzle> Nozzle => _nozzle.AsReadOnly();
}
