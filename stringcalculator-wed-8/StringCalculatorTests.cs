
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("4",4)]
    [InlineData("5",5)]
    [InlineData("1242",1242)]
    public void SingleDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("4,5",9)]
    [InlineData("2,3",5)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("4,5,6", 15)]
    [InlineData("2,300,15", 317)]
    public void MultipleNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,5,45,60", 114)]
    [InlineData("12\n340\n1", 353)]
    public void NewLineSplitters(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void DifferentDelimiters()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("//;\n1;2");
        
        Assert.Equal(3, result);
    }
}
