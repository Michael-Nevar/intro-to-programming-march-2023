
using System.ComponentModel;
using System.Xml.Schema;

namespace StringCalculator;

public class StringCalculator
{

    private readonly ILogger _logger;

    public StringCalculator(ILogger logger)
    {
        _logger = logger;
    }

    public int Add(string numbers)
    {
        int total = numbers == "" ? 0 : numbers.Split(',', '\n')
                .Select(int.Parse)
                .Sum();
        
        //WTCYWYH
        _logger.Write(total.ToString());
        return total;
    }
}

public interface ILogger
{
    void Write(string message);
}
