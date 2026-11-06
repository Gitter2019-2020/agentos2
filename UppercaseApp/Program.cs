// Minimal ASP.NET Core host used as a console app: reads stdin, writes uppercase to stdout.
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
var app = builder.Build();

string? line;
while ((line = Console.ReadLine()) is not null)
{
    Console.WriteLine(line.ToUpperInvariant());
}
