namespace PrinterApplication.Models;
public class FanStatus
{
    public bool IsOn { get; }

    public FanStatus(bool isOn)
    {
        IsOn = isOn;
    }

    public override string ToString()
    {
        return $"IsOn: {IsOn}";
    }
}
