using Microsoft.Extensions.Logging;

public class HelloWorldService
{
    private readonly ILogger<HelloWorldService> _logger;

    public HelloWorldService(ILogger<HelloWorldService> logger)
    {
        _logger = logger;
    }

    public string PrintMessage()
    {
        string message = "Hello, World!";
        _logger.LogInformation(message);
        return message;
    }
}