
using Xunit.Sdk;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers == "") return 0;
        numbers = numbers.Replace("\n", ",");
        var sum = 0;
        var numberList = numbers.Split(',');
        foreach (var number in numberList)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
}
