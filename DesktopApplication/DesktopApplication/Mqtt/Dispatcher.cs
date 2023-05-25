using MQTTnet;
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
                "3dprinter/1/nozzle" => NozzleDispatcher,
                "3dprinter/1/bed" => BedDispatcher,
                "3dprinter/1/env" => EnvironmentDispatcher,
                "3dprinter/1/resin" => ResinDispatcher,
                "3dprinter/1/accelerometer" => AccelerometerDispatcher,
                "3dprinter/1/motor/x/position" => MotorDispatcher,
                "3dprinter/1/motor/y/position" => MotorDispatcher,
                "3dprinter/1/motor/z/position" => MotorDispatcher,
                _ => (m) => Debug.WriteLine("Unknown topic: " + m.Topic)
            };
            toBeCalled(mrea.ApplicationMessage);
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
        var extruder = bool.Parse(payload[2]);
        BedStorage.Add(new Bed(temperature, fan, extruder));
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
        ResinStorage.Add(new Resin(resinLevel));
    }
    #endregion
    
    #region Accelerometer
    private static void AccelerometerDispatcher(MqttApplicationMessage message)
    {
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
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload);
        var motorId = Enum.Parse<MotorId>(message.Topic.ToLower().Trim('/').Split('/')[3]);

        MotorStorage.Add(new MotorReading(motorId, double.Parse(payload)));
    }
    #endregion
}
