#r "System.Windows.Forms.dll"

using System;
using System.Windows.Forms;

public interface ILogger
{
    void WriteInfo(string name);
    void WriteWarning(string name);
    void WriteError(string name);
}

public class ConsoleLogger
        : ILogger
{
    public static readonly string ErrorLabel = "ERROR";
    public static readonly string WarningLabel = "WARNING";
    public static readonly string InfoLabel = "INFO";

    protected virtual void WriteMessage(string severity, string message)
    {
        Console.WriteLine($"{severity} - {message}");

    }
    public void LogError(string message)
    { //passing info into writemessage function
        WriteMessage(ErrorLabel, message);
    }

    public void LogWarning(string message)
    {
        WriteMessage(WarningLabel, message);
    }

    public void LogInfo(string message)
    {
        WriteMessage(InfoLabel, message);
    }
}

    public static void WriteMessage(string severity, string message)
    {
        Console.WriteLine($"{severity} - {message}");
    }
}

Logger.LogError("Something's broken");
Logger.LogWarning("Something might be broken");
Logger.LogInfo("Something happened");

