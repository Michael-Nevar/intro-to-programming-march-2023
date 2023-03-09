

namespace OnCallDeveloperApi.Controllers;

public class OnCallDeveloperController : ControllerBase
{
    private readonly IProvideTheBuisnessClock _businessClock;

    public OnCallDeveloperController(IProvideTheBuisnessClock businessClock)
    {
        _businessClock = businessClock;
    }


    // GET /oncalldeveloper -> 200 OK
    [HttpGet("/oncalldeveloper")]
    public ActionResult GetOnCallDeveloper()
    {
        GetOnCallDeveloperResponse response;
        if (_businessClock.IsDuringBusinessHours())
        {
            response =
            new GetOnCallDeveloperResponse("Michael N.", "555-1212", "mike@aol.com");
        }
        else
        {
            response =
            new GetOnCallDeveloperResponse("OnCallCorp Customer Service", "800 GOOD-LUCK", "oncall@company.com");
        }
        return Ok(response); // 200 status code
    }
}
