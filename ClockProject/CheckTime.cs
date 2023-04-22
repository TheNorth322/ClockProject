namespace ClockProject;

public class TimeChecker
{
    public string CheckTime(IDigitalClock clock)
    {
        return clock.GetTime();
    } 
}