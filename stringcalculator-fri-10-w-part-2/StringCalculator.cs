
using System.ComponentModel;
using System.Xml.Schema;

namespace StringCalculator;

public class StringCalculator
{

    private readonly ILogger _logger;
    private readonly IWebService _webService;

    public StringCalculator(ILogger logger, IWebService webService)
    {
        _logger = logger;
        _webService = webService;
    }

    public int Add(string numbers)
    {
        int total = numbers == "" ? 0 : numbers.Split(',', '\n')
                .Select(int.Parse)
                .Sum();

        //WTCYWYH
        try
        {
            _logger.Write(total.ToString());
        }
        catch (LoggingException ex)
        {
            _webService.LoggingFailed(ex.Message);
        }
        
        return total;
    }
}

public interface IWebService
{
    void LoggingFailed(string failureMessage);
}
