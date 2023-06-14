using PrinterApplication.Mqtt;
using Serilog;

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

        Log.Logger = new LoggerConfiguration()
         .WriteTo.Console()
         .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
         .CreateLogger();

        Log.Information("Starting application");

        DotEnv.Load("../../../.env");
        ApplicationConfiguration.Initialize();
        IMqttProvider mqtt = new MqttProvider(
            (Environment.GetEnvironmentVariable("MQTT_URL") ?? "").Trim(),
            (Environment.GetEnvironmentVariable("MQTT_USER") ?? "").Trim(),
            (Environment.GetEnvironmentVariable("MQTT_PASSWORD") ?? "").Trim());
        await mqtt.Subscribe("3dPrinter/1/#");
        await mqtt.Subscribe("3dprinter/1/#");
        mqtt.RegisterActionMessageReceived(async e =>
        {
            Dispatcher.HandleMessage(new object(), e);
        });

        Application.Run(new Form1(mqtt));

        mqtt.Stop();
    }
}
