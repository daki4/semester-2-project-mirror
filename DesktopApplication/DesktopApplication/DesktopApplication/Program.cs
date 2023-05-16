using PrinterApplication.Mqtt;
using System.Diagnostics;

namespace PrinterApplication.DesktopApplication;

public static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static async Task Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        DotEnv.Load("../../../../../../.env");
        ApplicationConfiguration.Initialize();
        Debug.WriteLine(Environment.GetEnvironmentVariable("MQTT_URL"));
        //IMqttProvider mqtt = new MqttProvider.MqttProvider(
        //    Environment.GetEnvironmentVariable("MQTT_URL"),
        //    Environment.GetEnvironmentVariable("MQTT_USER"),
        //    Environment.GetEnvironmentVariable("MQTT_PASSWORD"));
        IMqttProvider mqtt = new MqttProvider(
            "mqtt.yordanmitev.me",
            "3dPrinterUsr",
            "somepassword"
            );
        await mqtt.Subscribe("3dPrinter/1/#");
        await mqtt.Subscribe("3dprinter/1/#");
        await mqtt.Publish("test", "test2");
        mqtt.RegisterActionMessageReceived(async e =>
        {
            Dispatcher.HandleMessage(new object(), e);
        });

        Application.Run(new Form1(mqtt));

        mqtt.Stop();
    }
}
