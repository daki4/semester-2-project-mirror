namespace DesktopApplication;

public partial class Form1 : Form
{


    public Form1()
    {
        InitializeComponent();
        SendTextToGui.TextReceived += new(WriteStupidText);
    }

    public void WriteStupidText(object _, TextTransferEventArgs text)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<string>(WriteStupidText), text.Text);
            return;
        }
        WriteStupidText(text.Text);
    }

    public void WriteStupidText(string Text)
    {
        lbMessageDump.Items.Add(Text);
    }
}