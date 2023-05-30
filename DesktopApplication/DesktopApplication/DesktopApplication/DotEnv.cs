using Serilog;

namespace PrinterApplication.DesktopApplication;

public static class DotEnv
{
    public static void Load(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return;
        }

        foreach (var line in File.ReadAllLines(filePath))
        {
            if (line.StartsWith("#"))
            {
                continue;
            }
            var parts = line.Split(
                '=',
                StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
            {
                continue;
            }
            Log.Debug(string.Join(" ", parts));

            Environment.SetEnvironmentVariable(parts[0], parts[1]);
        }
    }
}
