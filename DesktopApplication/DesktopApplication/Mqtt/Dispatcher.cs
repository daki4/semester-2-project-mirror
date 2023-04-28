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
            Func<MqttApplicationMessage, object> toBeCalled = mrea.ApplicationMessage.Topic.ToLower() switch
            {
                "3dprinter/1/temperature" => TemperatureDispatcher,
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

    private static object TemperatureDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(";");
        var temperatureReading = double.Parse(payload[0]);
        var fanStatus = bool.Parse(payload[1]);
        TemperatureStorage.Add(new Temperature(temperatureReading, fanStatus));
        return new Temperature(temperatureReading, fanStatus);
    }

    #endregion

    #region Resin
    private static object ResinDispatcher(MqttApplicationMessage message)
    {
        var resinLevel = double.Parse(System.Text.Encoding.UTF8.GetString(message.Payload));
        ResinStorage.Add(new Resin(resinLevel));
        return new Resin(resinLevel);
    }

    #endregion

    #region Door
    private static object DoorDispatcher(MqttApplicationMessage message)
    {
        var doorStatus = bool.Parse(System.Text.Encoding.UTF8.GetString(message.Payload));
        DoorStorage.Add(new Door(doorStatus));
        return new Door(doorStatus);
    }
    #endregion
    
    #region Heater

    private static object HeaterDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload);
        var heaterStatus = bool.Parse(payload);
        HeaterStorage.Add(new Heater(heaterStatus));
        return new Heater(heaterStatus);
    }

    #endregion

    // TODO: Not implemented any storage for those
    
    #region Accelerometer

    private static object AccelerometerDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(";");
        var readings = payload.SkipLast(1).Select(double.Parse).ToArray();
        
        return new Accelerometer(readings[0], readings[1], readings[2], bool.Parse(payload[3]));
    }

    #endregion

    #region Motors
    
    private static object MotorDispatcher(MqttApplicationMessage message)
    {
        var payload = System.Text.Encoding.UTF8.GetString(message.Payload).Split(";");
        var position = payload.Select(double.Parse).ToArray();

        return new MotorReading(position[0], position[1], position[2]);
    }
    
    #endregion
}
