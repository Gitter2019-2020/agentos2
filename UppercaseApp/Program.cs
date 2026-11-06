// Minimal ASP.NET Core host used as a console app: reads stdin, writes reversed uppercase to stdout.
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
var app = builder.Build();

string? line;
while ((line = Console.ReadLine()) is not null)
{
    var chars = line.ToUpperInvariant().ToCharArray();
    Array.Reverse(chars);
    Console.WriteLine(new string(chars));
}
