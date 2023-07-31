using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ExampleDotnet.Library;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder();
builder.Services.AddSingleton<HelloWorldService>();

var app = builder.Build();

app.MapGet("/", (HelloWorldService service) => service.PrintMessage());

app.Run();