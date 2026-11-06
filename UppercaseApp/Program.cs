var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
var app = builder.Build();

foreach (var number in FibonacciNumbers.UpTo(500))
{
    Console.WriteLine(number);
}

public static class FibonacciNumbers
{
    public static IEnumerable<int> UpTo(int limit)
    {
        if (limit < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(limit), "The limit must be non-negative.");
        }

        long previous = 0;
        long current = 1;

        while (previous <= limit)
        {
            yield return (int)previous;

            var next = previous + current;
            previous = current;
            current = next;
        }
    }
}
