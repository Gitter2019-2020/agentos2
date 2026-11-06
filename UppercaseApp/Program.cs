// Minimal ASP.NET Core host used as a console app: writes Fibonacci numbers through 500 to stdout.
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
var app = builder.Build();

const int Limit = 500;
var previous = 0;
var current = 1;

while (previous <= Limit)
{
    Console.WriteLine(previous);
    var next = previous + current;
    previous = current;
    current = next;
}
