namespace LaunchJsonDemo;

class Program
{
    // Move .vscode folder into rood diretory before running in debug mode
    static void Main(string[] Args)
    {
        string? appMode = Environment.GetEnvironmentVariable("APP_MODE");
        Console.WriteLine("APP_MODE = " + (appMode ?? "not set"));

        if (appMode == "Development")
        {
            Console.WriteLine("Running in development mode: verbose logging enabled.");
        }
        else if (appMode == "Test")
        {
            Console.WriteLine("Running in test mode: using test data.");
        }
        else if (appMode == "Production")
        {
            Console.WriteLine("Running in production mode: normal operations.");
        }
        else
        {
            Console.WriteLine("APP_MODE not recognized: default behavior.");
        }
    }
}