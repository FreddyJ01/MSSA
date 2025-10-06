using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

class Program
{
    static async Task Main(string[] args)
    {
        //Configure a builder using Miscrosoft.Extensions.Hosting
        var builder = Host.CreateApplicationBuilder(args);

        builder.Logging.ClearProviders(); //Ensures no other logging will take place
        builder.Logging.AddConsole(); //Adds this logging console

        builder.Services.AddHostedService<ConsoleWorker>();

        //Creating a host
        var host = builder.Build();

        await host.RunAsync();
    }

    public class ConsoleWorker : BackgroundService
    {
        private readonly ILogger<ConsoleWorker> _logger;

        public ConsoleWorker(ILogger<ConsoleWorker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("App starting in...");
            for (int i = 0; i < 5 && !stoppingToken.IsCancellationRequested; i++)
            {
                _logger.LogInformation($"Working... {i + 1}");
                await Task.Delay(500, stoppingToken);
            }
            _logger.LogInformation("App is shutting down...");
        } 
    }
}