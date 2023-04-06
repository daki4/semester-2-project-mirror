namespace DesktopApplication.MqttProvider;

public interface IMqttProvider
{
    Task Subscribe(string topic);
    Task Publish(string topic, string message);
    void Stop();
}
