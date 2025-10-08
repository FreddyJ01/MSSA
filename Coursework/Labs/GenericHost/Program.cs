using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder();

        builder.Logging.ClearProviders();
        builder.Logging.AddConsole();

        builder.Services.AddSingleton<TipProvider>();
        builder.Services.AddHostedService<HydrationWorker>();

        var host = builder.Build();

        await host.RunAsync();
    }
}

class TipProvider
{
    string[] tips =
        {
            "Sip water between tasks.",
            "Keep a bottle within reach.",
            "Set mini goals (8 oz every hour).",
            "Add a squeeze of lemon for flavor."
        };

    Random randomizer = new Random();

    public string GetNewTip()
    {
        int selection = randomizer.Next(tips.Length);
        return $"Tip {selection}: {tips[selection]}";
    }
}

class HydrationWorker : BackgroundService
{
    private readonly ILogger<HydrationWorker> _logger;
    private readonly TipProvider _tipProvider;

    public HydrationWorker(ILogger<HydrationWorker> logger, TipProvider tipProvider)
    {
        _logger = logger;
        _tipProvider = tipProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Hydration Reminder is starting...");

        Random randomizer1 = new Random();

        for (int i = 0; i <= 5 && !stoppingToken.IsCancellationRequested; i++)
        {
            _logger.LogInformation(_tipProvider.GetNewTip());
            await Task.Delay(1000); // wait 1 second
        }

        _logger.LogInformation("Hydration Reminder is shutting down.");
    }
}




// class Program
// {
//     static async Task Main(string[] args)
//     {
//         var builder = Host.CreateApplicationBuilder(args);

//         builder.Logging.ClearProviders();
//         builder.Logging.AddConsole();

//         builder.Services.AddSingleton<QuoteProvider>();

//         builder.Services.AddHostedService<MotivationWorker>();

//         var host = builder.Build();

//         await host.RunAsync();

//     }
// }

// public class QuoteProvider
// {
//     static string[] quotes = new[]
//         {
//             "Stay positive!",
//             "Keep learning.",
//             "Trust the process.",
//             "Consistency is key."
//         };

//     Random randomizer = new Random();
//     public string GetRandomQuote()
//     {
//         int selection = randomizer.Next(quotes.Length);
//         string quote = $"Quote {selection}: {quotes[selection]}";
//         return quote;
//     }
// }

// public class MotivationWorker : BackgroundService
// {
//     private readonly ILogger<MotivationWorker> _logger;
//     private readonly QuoteProvider _quoteProvider;

//     public MotivationWorker(ILogger<MotivationWorker> logger, QuoteProvider quoteProvider)
//     {
//         _logger = logger;
//         _quoteProvider = quoteProvider;
//     }

//     protected override async Task ExecuteAsync(CancellationToken stoppingToken)
//     {
//         _logger.LogInformation("Motivation app is starting...");

//         for (int i = 0;  i <= 5 && !stoppingToken.IsCancellationRequested; i++)
//         {
//             _logger.LogInformation(_quoteProvider.GetRandomQuote());

//             try
//             {
//                 await Task.Delay(1000); // wait 1 second    
//             }
//             catch
//             {
//                 break;
//             }
//         }
//         _logger.LogInformation("Motivation app is shutting down.");
//     }
// }