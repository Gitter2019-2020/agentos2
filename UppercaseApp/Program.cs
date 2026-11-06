// Minimal ASP.NET Core host used as a console app: writes the first 15 prime numbers to stdout.
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
var app = builder.Build();

const int Count = 15;
var primes = new List<int>();
for (int candidate = 2; primes.Count < Count; candidate++)
{
    bool isPrime = true;
    foreach (var p in primes)
    {
        if (p * p > candidate) break;
        if (candidate % p == 0) { isPrime = false; break; }
    }
    if (isPrime) primes.Add(candidate);
}

foreach (var prime in primes)
{
    Console.WriteLine(prime);
}
