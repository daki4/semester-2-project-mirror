namespace DesktopApplication;

public class TextTransferEventArgs : EventArgs
{
    public string Text { get; }

    public TextTransferEventArgs(string text)
    {
        Text = text;
    }
}
