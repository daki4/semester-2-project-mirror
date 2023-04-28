using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Packets;
using MQTTnet.Server;

namespace PrinterApplication.Mqtt;

public class MqttProvider : IMqttProvider
{
    /// <summary>
    /// This is the managed MQTT Client that receives and subscribes to different topics.
    /// </summary>
    private IManagedMqttClient? _managedMqttClientSubscriber;

    /// <summary>
    /// This is the managed MQTT Client that sends the messages to the broker.
    /// </summary>
    private IManagedMqttClient? _managedMqttClientPublisher;

    /// <summary>
    /// This is the MQTT server.
    /// </summary>
    private MqttServer? _mqttServer;


    /// <summary>
    /// This is to be used to make an authenticated MQTT connection
    /// </summary>
    /// <param name="url">connection URL</param>
    /// <param name="username">MQTT username</param>
    /// <param name="password">MQTT password</param>
    public MqttProvider(string url, string username, string password)
    {
        Connect(url, username, password).Wait();
    }

    /// <summary>
    /// This is to be used to make an unauthenticated MQTT connection
    /// </summary>
    /// <param name="url">connection URL</param>
    public MqttProvider(string url)
    {
        Connect(url, null, null).Wait();
    }

    /// <summary>
    /// Connect to the MQTT broker
    /// </summary>
    /// <param name="url"></param>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    private async Task Connect(string url, string? username, string? password)
    {
        var managedMqttClientSubscriber = new MqttFactory().CreateManagedMqttClient();
        var managedMqttClientPublisher = new MqttFactory().CreateManagedMqttClient();

        var options = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(5));
        var clientOptions = new MqttClientOptionsBuilder()
                .WithClientId(Guid.NewGuid().ToString())
                .WithTcpServer(url)
                .WithCleanSession();
        if (username != null && password != null)
        {
            clientOptions.WithCredentials(username, password);
        }
        clientOptions.Build();
        var managedClientOptions = options.WithClientOptions(clientOptions).Build();
        //managedMqttClientSubscriber.ApplicationMessageReceivedAsync += HandleReceivedMessage;

        await managedMqttClientSubscriber.StartAsync(managedClientOptions);
        await managedMqttClientPublisher.StartAsync(managedClientOptions);

        _managedMqttClientSubscriber = managedMqttClientSubscriber;
        _managedMqttClientPublisher = managedMqttClientPublisher;
    }

    /// <summary>
    /// Subscribe to a topic
    /// </summary>
    /// <param name="topic"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task Subscribe(string topic)
    {
        if (_managedMqttClientSubscriber == null)
        {
            throw new InvalidOperationException("MQTT client not initialized");
        }
        var topicFilter = new MqttTopicFilterBuilder().WithTopic(topic).Build();
        await _managedMqttClientSubscriber.SubscribeAsync(new List<MqttTopicFilter> { topicFilter });
    }

    /// <summary>
    /// Publish a message to a topic
    /// </summary>
    /// <param name="topic"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task Publish(string topic, string message)
    {
        if (_managedMqttClientPublisher == null)
        {
            throw new InvalidOperationException("MQTT client not initialized");
        }
        var mqttMessage = new MqttApplicationMessageBuilder()
            .WithTopic(topic)
            .WithPayload(message)
            .WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.ExactlyOnce)
            .Build();
        await _managedMqttClientPublisher.EnqueueAsync(mqttMessage);
    }

    /// <summary>
    /// Stop the MQTT Client
    /// </summary>
    public void Stop()
    {
        if (
            _managedMqttClientSubscriber != null &&
            _managedMqttClientPublisher != null
            )
        {
            _managedMqttClientSubscriber.Dispose();
            _managedMqttClientPublisher.Dispose();
        }
    }
    
    public void RegisterActionMessageReceived(Func<MqttApplicationMessageReceivedEventArgs, Task> action)
    {
        if (_managedMqttClientSubscriber == null)
        {
            return;
        }
        _managedMqttClientSubscriber.ApplicationMessageReceivedAsync += action;
    }
}
