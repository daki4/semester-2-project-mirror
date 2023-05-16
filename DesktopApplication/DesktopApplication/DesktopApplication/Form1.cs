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

        DoorStorage.OnDoorStateChanged += OnDoorStateChanged;
        TemperatureStorage.TemperatureChanged += OnTemperatureChanged;
        ResinStorage.ResinReceived += OnResinReceived;
        ResinStorage.ResinLevelLow += OnResinLevelLow;
        ResinStorage.ResinRefilled += OnResinRefilled;
        HeaterStorage.HeaterStateChanged += OnHeaterStateChanged;
        AccelerometerStorage.OnAccelerometerBalancedStateChanged += OnAccelerometerBalancedStateChanged;
        AccelerometerStorage.OnAccelerometerDataReceived += OnAccelerometerDataReceived;
        FanStatusStorage.OnFanStatusChanged += OnFanStatusChanged;
    }

    private void OnFanStatusChanged(object? sender, FanStatusChangedEventArgs e)
    {
        lblFanStatus.Text = e.status.IsOn ? "On" : "Off";
        lblFanStatus.ForeColor = e.status.IsOn ? Color.Black : Color.Red;
    }

    private void OnAccelerometerDataReceived(object _, AccelerometerEventArgs e)
    {
        //lblAccelerometerBalanced.Text = e.Accelerometer.IsLeveled ? "Leveled" : "Not leveled";
        if(InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnAccelerometerDataReceived(_, e); }));
        }
        lblAccelerationX.Text = $" {e.Accelerometer.X}";
        lblAccelerationY.Text = $" {e.Accelerometer.Y}";
        lblAccelerationZ.Text = $" {e.Accelerometer.Z}";
    }


    private void OnAccelerometerBalancedStateChanged(object _, AccelerometeBalancedStateChangedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnAccelerometerBalancedStateChanged(_, e); }));
        }
        lblAccelerometerBalanced.Text = e.IsLeveled ? "Yes" : "No";
        lblAccelerometerBalanced.ForeColor = e.IsLeveled ? Color.Black : Color.Red;
    }

    private void OnDoorStateChanged(object _, DoorStateChangedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnDoorStateChanged(_, e); }));
        }
        lblDoorStatus.Text = e.IsOpen ? "Open" : "Closed";
        lblDoorStatus.ForeColor = e.IsOpen ? Color.Red : Color.Black;
    }

    private void OnTemperatureChanged(object _, TemperatureChangedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnTemperatureChanged(_, e); }));
            return;
        }
        lblTemperature.Text = $"{e.Temperature.Reading}C";
    }

    private void OnResinReceived(object _, ResinReceivedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnResinReceived(_, e); }));
            return;
        }
        lblResinLevel.Text = $"{e.Resin.Level}%";
    }

    private void OnResinLevelLow(object _, ResinLevelLowEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnResinLevelLow(_, e); }));
            return;
        }
        lblLowResinLevel.Text = "Low";
        lblLowResinLevel.ForeColor = Color.Red;
    }

    private void OnResinRefilled(object _, ResinRefilledEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnResinRefilled(_, e); }));
            return;
        }
        lblLowResinLevel.Text = e.Resin.IsLow ? "Low" : "Good";
        lblLowResinLevel.ForeColor = e.Resin.IsLow ? Color.Red : Color.Black;
    }

    private void OnHeaterStateChanged(object _, HeaterStateChangedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnHeaterStateChanged(_, e); }));
            return;
        }
        lblHeaterStatus.Text = e.Heater.IsOn ? "On" : "Off";
        lblHeaterStatus.ForeColor = e.Heater.IsOn ? Color.Black : Color.Red;
    }

    private void btnSetTargetTemperature_Click(object sender, EventArgs e)
    {
        // TODO: Implement
        _provider.Publish("3dPrinter/1/temperature/target", tbSetTargetTemperature.Text);
        lblTargetTemperature.Text = tbSetTargetTemperature.Text;
    }
}
