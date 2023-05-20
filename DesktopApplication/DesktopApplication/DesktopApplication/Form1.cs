namespace PrinterApplication.DesktopApplication;

using PrinterApplication.Mqtt;
using PrinterApplication.Storage;
using System;

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
        NozzleStorage.NozzleDataReceived += OnNozzleDataReceived;
        NozzleStorage.NozzleFanStateChanged += OnNozzleFanStateChanged;
        NozzleStorage.NozzleExtruderStateChanged += OnNozzleExtruderStateChanged;
        ChassisEnvironmentStorage.ChassisEnvironmentDataReceived += OnChassisEnvironmentDataReceived;
        ChassisEnvironmentStorage.ChassisDoorStateChanged += OnChassisDoorStateChanged;
    }

    private void OnChassisDoorStateChanged(object? sender, EnvironmentDataReceivedEventArgs e)
    {
        lblDoorStatus.Text = $"{(e.Environment.DoorIsClosed ? "Yes" : "No")}";
        lblDoorStatus.ForeColor = e.Environment.DoorIsClosed ? Color.Black : Color.Red;
    }

    private void OnChassisEnvironmentDataReceived(object? sender, EnvironmentDataReceivedEventArgs e)
    {
        lblEnvironmentTemperature.Text = $"{e.Environment.Temperature}C";
        lblEnvironmentHumidity.Text = $"{e.Environment.RelativeHumidity}%";
    }

    private void OnNozzleExtruderStateChanged(object? sender, NozzleDataReceivedEventArgs e)
    {
        lblNozzleExtruderStatus.Text = $"{(e.Nozzle.ExtruderIsOn ? "On" : "Off")}";
    }

    private void OnNozzleFanStateChanged(object? sender, NozzleDataReceivedEventArgs e)
    {
        lblNozzleFanStatus.Text = $"{(e.Nozzle.FanIsOn ? "On" : "Off")}";
    }

    private void OnNozzleDataReceived(object? sender, NozzleDataReceivedEventArgs e)
    {
        lblNozzleTemperature.Text = $"{e.Nozzle.Temperature}C";
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
