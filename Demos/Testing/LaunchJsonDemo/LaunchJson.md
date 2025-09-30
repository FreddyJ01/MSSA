
# Visual Studio Code and `launch.json`

## Why Edit `launch.json`?

Even with the C# Dev Kit installed, you may need to edit `launch.json` for:
- **Command-line arguments** (e.g., `args`: `["input.txt", "verbose"]`)
- **Custom environment variables** (e.g., `env`: `{ "ASPNETCORE_ENVIRONMENT": "Development" }`)
- **Setting a different working directory**
- **Remote debugging** (attach to a process on another machine or container)
- **Enabling hot reload or special debugging flags**
- **Attaching to background services**
- **Customizing the runtime/SDK path** (targeting a specific .NET version)

These settings ensure VS Code launches your program with the correct inputs and environment, which cannot be configured by breakpoints alone.

---

## Example: Debugging with Environment Variables

Suppose you have a console app that behaves differently based on the runtime mode (Development, Test, Production). You can set an environment variable in `launch.json` to control this behavior during debugging.

### `Program.cs`
```csharp
using System;

class Program
{
    static void Main()
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
```

### `.vscode/launch.json`
> **Note:** Update the DLL name in the `program` entry to match your build output.
```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".NET: Launch with APP_MODE",
            "type": "coreclr",
            "request": "launch",
            "program": "${workspaceFolder}/bin/Debug/net8.0/ConsoleApp2.dll",
            "env": {
                "APP_MODE": "Development"
            }
        }
    ]
}
```

---

## Tips
- Always check your build output folder for the correct DLL name.
- You can add multiple configurations for different modes or arguments.
- Use comments in `launch.json` to document each configuration.

---

For more info, see the [VS Code documentation on debugging](https://code.visualstudio.com/docs/editor/debugging).
