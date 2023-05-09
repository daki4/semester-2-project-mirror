namespace PrinterApplication.Models;
public class Door
{
    public bool IsOpen { get; }

    public Door(bool isOpen)
    {
        IsOpen = isOpen;
    }

    public override string ToString()
    {
        return $"IsOpen: {IsOpen}";
    }
}
