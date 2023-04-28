namespace PrinterApplication.Storage;
public class DoorStateChangedEventArgs : EventArgs
{
    public bool IsOpen { get; }

    public DoorStateChangedEventArgs(bool isOpen)
    {
        IsOpen = isOpen;
    }
}
