using MQTTnet.Client;

namespace PrinterApplication.Mqtt;

public interface IMqttProvider
{
    Task Subscribe(string topic);
    Task Publish(string topic, string message);
    void RegisterActionMessageReceived(Func<MqttApplicationMessageReceivedEventArgs, Task> action);
    void Stop();
}
