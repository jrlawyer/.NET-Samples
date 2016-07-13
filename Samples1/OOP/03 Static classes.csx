using System;

//Console.WriteLine("Hello");

//Math

public static class Logger
{
    public static readonly string ErrorLabel = "ERROR";
    public static readonly string WarningLabel = "WARNING";
    public static readonly string InfoLabel = "INFO";

    private static void WriteMessage(string severity, string message)
    {
        Console.WriteLine($"[{severity} - {DateTime.UtcNow:O}] {message}");

    }
    public static void LogError(string message)
    { //passing info into writemessage function
        WriteMessage(ErrorLabel, message);
    }
    
    public static void LogWarning(string message)
    {
        WriteMessage(WarningLabel, message);
    }   

public static void LogInfo(string message)
    {
        WriteMessage(InfoLabel, message);
    }
}


Logger.LogError("Something's broken");
Logger.LogWarning("Something might be broken");
Logger.LogInfo("Something happened");

Logger.

