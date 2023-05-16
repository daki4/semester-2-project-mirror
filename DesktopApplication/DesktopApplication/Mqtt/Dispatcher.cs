﻿using MQTTnet;
using MQTTnet.Client;
using PrinterApplication.Models;
using PrinterApplication.Storage;
using System.Diagnostics;

namespace PrinterApplication.Mqtt;

public static class Dispatcher
{
    public static void HandleMessage(object sender, EventArgs args)
    {
        Debug.WriteLine(((MqttApplicationMessageReceivedEventArgs)args).ApplicationMessage.Topic.ToLower());
        if (args is MqttApplicationMessageReceivedEventArgs mrea)
        {
            Action<MqttApplicationMessage> toBeCalled = mrea.ApplicationMessage.Topic.ToLower().Trim('/') switch
            {
                "3dprinter/1/temperature" => TemperatureDispatcher,
                "3dprinter/1/fanstatus" => FanStatusDispatcher,
                "3dprinter/1/resin" => ResinDispatcher,
                "3dprinter/1/door" => DoorDispatcher,
                "3dprinter/1/heater" => HeaterDispatcher,
                "3dprinter/1/accelerometer" => AccelerometerDispatcher,
                "3dprinter/1/motor" => MotorDispatcher,
            };
            toBeCalled(mrea.ApplicationMessage);
        }
    }

    #region Temperature
    private static void TemperatureDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(";");
        var temperatureReading = double.Parse(payload[0]);
        TemperatureStorage.Add(new Temperature(temperatureReading));
    }
    #endregion

    #region FanStatus
    private static void FanStatusDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(";");
        var fanStatus = bool.Parse(payload[0]);
        FanStatusStorage.Add(new FanStatus(fanStatus));
    }
    #endregion

    #region Resin
    private static void ResinDispatcher(MqttApplicationMessage message)
    {
        var resinLevel = double.Parse(System.Text.Encoding.UTF8.GetString(message.Payload));
        ResinStorage.Add(new Resin(resinLevel));
    }
    #endregion

    #region Door
    private static void DoorDispatcher(MqttApplicationMessage message)
    {
        var doorStatus = bool.Parse(System.Text.Encoding.UTF8.GetString(message.Payload));
        DoorStorage.Add(new Door(doorStatus));
    }
    #endregion

    #region Heater
    private static void HeaterDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload);
        var heaterStatus = bool.Parse(payload);
        HeaterStorage.Add(new Heater(heaterStatus));
    }
    #endregion

    // TODO: Not implemented any storage for those

    #region Accelerometer
    // TODO: Fix this method (for fabi)
    private static void AccelerometerDispatcher(MqttApplicationMessage message)
    {
        /*
        var readings = payload.SkipLast(1).Select(double.Parse).ToArray();
        

        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(";");

        // Extract the accelerometer readings from the payload
        var readings = payload.Take(payload.Length - 1).Select(double.Parse).ToArray();

        // Get the leveled value from the payload
        var leveled = bool.Parse(payload.Last());

        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(";");

        var x_str = payload[0];
        var y_str = payload[1];
        var z_str = payload[2];
        var leveled = bool.Parse(payload[3]);

        var accelerometerReading = new AccelerometerReading(x_str, y_str, z_str, leveled);
        accelerometerStorage.Add(accelerometerReading);
        */

        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(',');
        var x = double.Parse(payload[0]);
        var y = double.Parse(payload[1]);
        var z = double.Parse(payload[2]);
        var isLeveled = bool.Parse(payload[3]);
        AccelerometerStorage.Add(new Accelerometer(x, y, z, isLeveled));

    }
    #endregion

    #region Motors
    private static void MotorDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(";");
        var position = payload.Select(double.Parse).ToArray();
    }
    #endregion
}
