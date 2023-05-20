namespace PrinterApplication.DesktopApplication;

using PrinterApplication.Mqtt;
using PrinterApplication.Storage;

public partial class Form1 : Form
{
    IMqttProvider _provider;
    public Form1(IMqttProvider provider)
    {
        InitializeComponent();
        _provider = provider;
        ResinStorage.ResinReceived += OnResinReceived;
        ResinStorage.ResinLevelLow += OnResinLevelLow;
        ResinStorage.ResinRefilled += OnResinRefilled;
        AccelerometerStorage.OnAccelerometerBalancedStateChanged += OnAccelerometerBalancedStateChanged;
        AccelerometerStorage.OnAccelerometerDataReceived += OnAccelerometerDataReceived;
    }

    private void OnAccelerometerDataReceived(object? _, AccelerometerEventArgs e)
    {
        if(InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnAccelerometerDataReceived(_, e); }));
        }
        lblAccelerationX.Text = $" {e.Accelerometer.X}";
        lblAccelerationY.Text = $" {e.Accelerometer.Y}";
        lblAccelerationZ.Text = $" {e.Accelerometer.Z}";
    }

    private void OnAccelerometerBalancedStateChanged(object? _, AccelerometeBalancedStateChangedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnAccelerometerBalancedStateChanged(_, e); }));
        }
        lblAccelerometerBalanced.Text = e.IsLeveled ? "Yes" : "No";
        lblAccelerometerBalanced.ForeColor = e.IsLeveled ? Color.Black : Color.Red;
    }
    
    private void OnResinReceived(object? _, ResinReceivedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnResinReceived(_, e); }));
            return;
        }
        lblResinLevel.Text = $"{e.Resin.Level}%";
    }

    private void OnResinLevelLow(object? _, ResinLevelLowEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnResinLevelLow(_, e); }));
            return;
        }
        lblLowResinLevel.Text = "Low";
        lblLowResinLevel.ForeColor = Color.Red;
    }

    private void OnResinRefilled(object? _, ResinRefilledEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnResinRefilled(_, e); }));
            return;
        }
        lblLowResinLevel.Text = e.Resin.IsLow ? "Low" : "Good";
        lblLowResinLevel.ForeColor = e.Resin.IsLow ? Color.Red : Color.Black;
    }
}
