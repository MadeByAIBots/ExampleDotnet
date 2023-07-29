using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var services = new ServiceCollection()
    .AddLogging(builder => builder.AddConsole())
    .AddSingleton<HelloWorldService>()
    .BuildServiceProvider();

var helloWorldService = services.GetRequiredService<HelloWorldService>();
string message = helloWorldService.PrintMessage();
Console.WriteLine(message);