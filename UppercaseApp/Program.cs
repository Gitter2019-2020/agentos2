// Minimal ASP.NET Core host used as a console app: writes the first 3 prime numbers to stdout.
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
var app = builder.Build();

const int Count = 3;
var primes = new List<int>();
for (var candidate = 2; primes.Count < Count; candidate++)
{
    if (primes.TakeWhile(p => p * p <= candidate).All(p => candidate % p != 0))
    {
        primes.Add(candidate);
    }
}

foreach (var prime in primes)
{
    Console.WriteLine(prime);
}
