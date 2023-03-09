

namespace OnCallDeveloperApi.Controllers;

public class OnCallDeveloperController : ControllerBase
{

    // GET /oncalldeveloper -> 200 OK
    [HttpGet("/oncalldeveloper")]
    public ActionResult GetOnCallDeveloper()
    {
        var response =
            new GetOnCallDeveloperResponse("Michael N.", "555-1212", "mike@aol.com");
        return Ok(response);
    }
}
