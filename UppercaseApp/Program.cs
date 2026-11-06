// Minimal ASP.NET Core host used as a console app: reads stdin, writes uppercase to stdout.
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
var app = builder.Build();

string? line;
while ((line = Console.ReadLine()) is not null)
{
    Console.WriteLine(Transform(line));
}

// Uppercases, reverses, and inserts a digit (1-9 cycling) between each pair of characters.
static string Transform(string input)
{
    var chars = input.ToUpperInvariant().Reverse().ToArray();
    var sb = new System.Text.StringBuilder();
    for (var i = 0; i < chars.Length; i++)
    {
        if (i > 0) sb.Append((i - 1) % 9 + 1);
        sb.Append(chars[i]);
    }
    return sb.ToString();
}
