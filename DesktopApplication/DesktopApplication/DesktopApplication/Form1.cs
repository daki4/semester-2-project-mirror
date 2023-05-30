namespace PrinterApplication.DesktopApplication;

using PrinterApplication.Mqtt;
using PrinterApplication.Storage;
using System;
using System.Diagnostics;
using System.Security.Policy;
using Serilog;

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
        BedStorage.BedDataReceived += OnBedDataReceived;
        NozzleStorage.NozzleDataReceived += OnNozzleDataReceived;
        NozzleStorage.NozzleFanStateChanged += OnNozzleFanStateChanged;
        NozzleStorage.NozzleExtruderStateChanged += OnNozzleExtruderStateChanged;
        ChassisEnvironmentStorage.ChassisEnvironmentDataReceived += OnChassisEnvironmentDataReceived;
        ChassisEnvironmentStorage.ChassisDoorStateChanged += OnChassisDoorStateChanged;
        MotorStorage.OnMotorXDataReceived += OnMotorXDataReceived;
        MotorStorage.OnMotorYDataReceived += OnMotorYDataReceived;
        MotorStorage.OnMotorZDataReceived += OnMotorZDataReceived;
    }

    private void OnBedDataReceived(object? sender, BedDataReceivedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnBedDataReceived(sender, e); }));
            return;
        }
        lblBedFan.Text = e.Bed.FanIsOn ? "On" : "Off";
        lblBedHeater.Text = e.Bed.HeaterIsOn ? "On" : "Off";
        lblBedTemperature.Text = $"{e.Bed.Temperature}C";
    }

    private void OnMotorZDataReceived(object? sender, MotorEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnMotorZDataReceived(sender, e); }));
            return;
        }

        gbMotorZ.Text = $"Position Z: {e.Motor.Position}";
    }

    private void OnMotorYDataReceived(object? sender, MotorEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnMotorYDataReceived(sender, e); }));
            return;
        }

        gbMotorY.Text = $"Position Y: {e.Motor.Position}";
    }

    private void OnMotorXDataReceived(object? sender, MotorEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnMotorXDataReceived(sender, e); }));
            return;
        }
        gbMotorX.Text = $"Position X: {e.Motor.Position}";
    }

    private void OnChassisDoorStateChanged(object? _, EnvironmentDataReceivedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnChassisDoorStateChanged(_, e); }));
            return;
        }
        lblDoorStatus.Text = $"{(e.Environment.DoorIsClosed ? "Closed" : "Open")}";
        lblDoorStatus.ForeColor = e.Environment.DoorIsClosed ? Color.Black : Color.Red;
        Log.Information($"Door is {(e.Environment.DoorIsClosed ? "Closed" : "Open")}");
    }

    private void OnChassisEnvironmentDataReceived(object? _, EnvironmentDataReceivedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnChassisEnvironmentDataReceived(_, e); }));
            return;
        }
        lblEnvironmentTemperature.Text = $"{e.Environment.Temperature}C";
        lblEnvironmentHumidity.Text = $"{e.Environment.RelativeHumidity}%";
    }

    private void OnNozzleExtruderStateChanged(object? _, NozzleDataReceivedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnNozzleExtruderStateChanged(_, e); }));
            return;
        }
        lblNozzleExtruderStatus.Text = $"{(e.Nozzle.ExtruderIsOn ? "On" : "Off")}";
    }

    private void OnNozzleFanStateChanged(object? _, NozzleDataReceivedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnNozzleFanStateChanged(_, e); }));
            return;
        }
        lblNozzleFanStatus.Text = $"{(e.Nozzle.FanIsOn ? "On" : "Off")}";
    }

    private void OnNozzleDataReceived(object? _, NozzleDataReceivedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnNozzleDataReceived(_, e); }));
            return;
        }
        lblNozzleTemperature.Text = $"{e.Nozzle.Temperature}C";
    }

    private void OnAccelerometerDataReceived(object? _, AccelerometerEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new MethodInvoker(() => { OnAccelerometerDataReceived(_, e); }));
            return;
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
            return;
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
        if (e.Resin.IsLow)
        {
            Log.Information("Resin level: {Level}%", e.Resin.Level);
        }
        else
        {
            Log.Information("Resin level: {Level}%", e.Resin.Level);
        }
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
    private void SetTargetTemperature(double targetTemperature)
    {
        lblNozzleTargetTemperature.Text = $"{targetTemperature}C";
        _provider.Publish("3dPrinter/1/nozzle/temperature/target", targetTemperature.ToString());
    }
    private void btnSetTargetNozzleTemperature_Click(object sender, EventArgs e)
    {
        SetTargetTemperature(double.Parse(tbSetTargetNozzleTemperature.Text));
    }

    private void btnResetTargetNozzleTemperature_Click(object sender, EventArgs e)
    {
        SetTargetTemperature(25);
    }

    private void btnMotorStop_Click(object sender, EventArgs e)
    {
        _provider.Publish("3dPrinter/1/motor/stop", "1");
    }

    private void btnMotorGoHome_Click(object sender, EventArgs e)
    {
        _provider.Publish("3dPrinter/1/motor/homing", "1");
    }

    private void PublishDisable(string motor)
    {
        _provider.Publish($"3dPrinter/1/motor/{motor}/disable", "1");
    }

    private void btnMotorXDisable_Click(object sender, EventArgs e)
    {
        PublishDisable("x");
    }

    private void btnMotorYDisable_Click(object sender, EventArgs e)
    {
        PublishDisable("y");
    }

    private void btnMotorZDisable_Click(object sender, EventArgs e)
    {
        PublishDisable("z");
    }

    private void PublishToggle(string motor)
    {
        _provider.Publish($"3dPrinter/1/motor/{motor}/loop", "1");
    }

    private void btnMotorXToggle_Click(object sender, EventArgs e)
    {
        PublishToggle("x");
    }

    private void btnMotorYToggle_Click(object sender, EventArgs e)
    {
        PublishToggle("y");
    }

    private void btnMotorZToggle_Click(object sender, EventArgs e)
    {
        PublishToggle("z");
    }

    private void PublishSend(string motor, string key, string value)
    {
        _provider.Publish($"3dPrinter/1/motor/{motor}/{key}", value);
    }

    private void btnMotorXSend_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = new[] { tbMotorXSpeed, tbMotorXRelative, tbMotorXAbsolute, tbMotorXAbsoluteEnd, tbMotorXLoop };
        try
        {
            var firstTextBox = textBoxes.Where(textBox => textBox.Text != "" && int.TryParse(textBox.Text, out int a)).First();
            PublishSend("x", firstTextBox.Name.Split("X")[1].ToLower(), firstTextBox.Text);
        }
        catch (Exception)
        {
            Log.Warning("No valid value found to send for motor X");
        }
        finally
        {
            tbMotorXSpeed.Text = "";
            tbMotorXRelative.Text = "";
            tbMotorXAbsolute.Text = "";
            tbMotorXAbsoluteEnd.Text = "";
            tbMotorXLoop.Text = "";
        }
    }

    private void btnMotorYSend_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = new[] { tbMotorYSpeed, tbMotorYRelative, tbMotorYAbsolute, tbMotorYAbsoluteEnd, tbMotorYLoop };
        try
        {
            var firstTextBox = textBoxes.Where(textBox => textBox.Text != "" && int.TryParse(textBox.Text, out int a)).First();
            PublishSend("y", firstTextBox.Name.Split("Y")[1].ToLower(), firstTextBox.Text);
        }
        catch (Exception)
        {
            Log.Warning("No valid value found to send for motor Y");
        }
        finally
        {
            tbMotorYSpeed.Text = "";
            tbMotorYRelative.Text = "";
            tbMotorYAbsolute.Text = "";
            tbMotorYAbsoluteEnd.Text = "";
            tbMotorYLoop.Text = "";
        }
    }

    private void btnMotorZSend_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = new[] { tbMotorZSpeed, tbMotorZRelative, tbMotorZAbsolute, tbMotorZAbsoluteEnd, tbMotorZLoop };
        try
        {
            var firstTextBox = textBoxes.Where(textBox => textBox.Text != "" && int.TryParse(textBox.Text, out int a)).First();
            PublishSend("z", firstTextBox.Name.Split("Z")[1].ToLower(), firstTextBox.Text);
        }
        catch (Exception)
        {
            Log.Warning("No valid value found to send for motor Z");
        }
        finally
        {
            tbMotorZSpeed.Text = "";
            tbMotorZRelative.Text = "";
            tbMotorZAbsolute.Text = "";
            tbMotorZAbsoluteEnd.Text = "";
            tbMotorZLoop.Text = "";
        }
    }
}
