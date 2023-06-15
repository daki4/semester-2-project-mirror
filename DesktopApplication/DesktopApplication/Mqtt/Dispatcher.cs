using MQTTnet;
using MQTTnet.Client;
using PrinterApplication.Models;
using PrinterApplication.Storage;
using Serilog;
using System.Diagnostics;

namespace PrinterApplication.Mqtt;

public static class Dispatcher
{
    public static void HandleMessage(object sender, EventArgs args)
    {
        Debug.WriteLine(((MqttApplicationMessageReceivedEventArgs)args).ApplicationMessage.Topic.ToLower());
        if (args is MqttApplicationMessageReceivedEventArgs mrea)
        {
            Log.Information($"Message received on topic: {mrea.ApplicationMessage.Topic} with payload: {mrea.ApplicationMessage.ConvertPayloadToString()}");
            Action<MqttApplicationMessage> toBeCalled = mrea.ApplicationMessage.Topic.ToLower().Trim('/') switch
            {
                "3dprinter/1/nozzle" => NozzleDispatcher,
                "3dprinter/1/bed" => BedDispatcher,
                "3dprinter/1/env" => EnvironmentDispatcher,
                "3dprinter/1/resin" => ResinDispatcher,
                "3dprinter/1/accelerometer" => AccelerometerDispatcher,
                "3dprinter/1/motor/x/position" => MotorDispatcher,
                "3dprinter/1/motor/y/position" => MotorDispatcher,
                "3dprinter/1/motor/z/position" => MotorDispatcher,
                _ => (m) => Log.Verbose($"Unknown topic: {m.Topic}")
            };
            try
            {
                toBeCalled(mrea.ApplicationMessage);
            }
            catch (Exception)
            {
                Log.Warning($"Malformed message at topic: {mrea.ApplicationMessage.Topic} with payload: {mrea.ApplicationMessage.ConvertPayloadToString()}");
            }
        }
    }

    #region Nozzle
    private static void NozzleDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(';');
        var temperature = double.Parse(payload[0]);
        var fan = bool.Parse(payload[1]);
        var extruder = bool.Parse(payload[2]);

        NozzleStorage.Add(new Nozzle(temperature, fan, extruder));
    }
    #endregion

    #region Bed
    private static void BedDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(';');
        var temperature = double.Parse(payload[0]);
        var fan = bool.Parse(payload[1]);
        var heater = bool.Parse(payload[2]);
        BedStorage.Add(new Bed(temperature, fan, heater));
    }
    #endregion

    #region Chassis Environment
    private static void EnvironmentDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(';');
        var temperature = double.Parse(payload[0]);
        var door = bool.Parse(payload[1]);
        var humidity = double.Parse(payload[2]);

        ChassisEnvironmentStorage.Add(new ChassisEnvironment(temperature, door, humidity));
    }
    #endregion
        
    #region Resin
    private static void ResinDispatcher(MqttApplicationMessage message)
    {
        var resinLevel = double.Parse(System.Text.Encoding.UTF8.GetString(message.Payload));
        Log.Information($"new resin reading: {resinLevel}");
        ResinStorage.Add(new Resin(resinLevel));
    }
    #endregion

    #region Accelerometer
    private static void AccelerometerDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(';');
        var x = double.Parse(payload[0]);
        var y = double.Parse(payload[1]);
        var z = double.Parse(payload[2]);
        var isLeveled = bool.Parse(payload[3]);
        Log.Information($"New Accelerometer reading: X: {x}, Y: {y}, Z: {z}, isLeveled: {isLeveled}");
        AccelerometerStorage.Add(new Accelerometer(x, y, z, isLeveled));

    }
    #endregion

    #region Motors
    private static void MotorDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload);
        var motorId = message.Topic.Trim('/').Split("/")[3].ToLower() switch
        {
            "x" => MotorId.X,
            "y" => MotorId.Y,
            "z" => MotorId.Z,
            _ => throw new ArgumentException(message.Topic.Trim('/').Split("/")[3].ToLower())
        };
        Log.Information($"New Motor reading: {motorId} at {payload}");
        MotorStorage.Add(new MotorReading(motorId, double.Parse(payload)));
    }
    #endregion
}
