class Program
{
    static async Task Main(string[] args)
    {
        System.Console.WriteLine("App starting in...");
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine($"Working... {i + 1}");
            await Task.Delay(500);
        }
        System.Console.WriteLine("App is shutting down...");
    }
}