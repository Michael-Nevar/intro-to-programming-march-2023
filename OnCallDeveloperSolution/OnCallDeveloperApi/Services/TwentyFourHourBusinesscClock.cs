using OnCallDeveloperApi.Controllers;

namespace OnCallDeveloperApi.Services;

public class TwentyFourHourBusinesscClock : IProvideTheBuisnessClock
{
    public bool IsDuringBusinessHours()
    {
        return true;
    }
}
