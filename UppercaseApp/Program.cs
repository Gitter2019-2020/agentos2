// Minimal ASP.NET Core host used as a console app: writes the name Sammy 5 times to stdout.
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
var app = builder.Build();

const int Count = 5;
for (var i = 0; i < Count; i++)
{
    Console.WriteLine("Sammy");
}
