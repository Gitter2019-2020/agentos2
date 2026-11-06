namespace UppercaseApp.Tests;

public class FibonacciNumbersTests
{
    [Fact]
    public void UpTo_ReturnsAllFibonacciNumbersThroughTheLimit()
    {
        var numbers = FibonacciNumbers.UpTo(500);

        Assert.Equal(new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 }, numbers);
    }

    [Fact]
    public void UpTo_Zero_ReturnsOnlyZero()
    {
        var numbers = FibonacciNumbers.UpTo(0);

        Assert.Equal(new[] { 0 }, numbers);
    }

    [Fact]
    public void UpTo_NegativeLimit_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => FibonacciNumbers.UpTo(-1).ToList());
    }
}
