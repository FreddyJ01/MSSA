namespace AAA;

class Program
{
    static async Task Main(string[] args)
    {
        System.Console.WriteLine("Starting background task...");
        var backgroundTask = DoBackgroundWorkAsync();

        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine($"Main thread is free to do work...");
            await Task.Delay(1000);
        }

        await backgroundTask;
        System.Console.WriteLine("All work done");
    }

    static async Task DoBackgroundWorkAsync()
    {
        System.Console.WriteLine("Background task started...");
        await Task.Delay(5000);
        System.Console.WriteLine("Background task finished");
    }
};
