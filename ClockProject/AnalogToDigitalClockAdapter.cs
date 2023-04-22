namespace ClockProject;

public class AnalogToDigitalClockAdapter : IDigitalClock
{
    private IAnalogClock _analogClock;

    public AnalogToDigitalClockAdapter(IAnalogClock analogClock)
    {
        _analogClock = analogClock;
    }
    
    public string GetTime()
    {
       return _analogClock.GetTime(); 
    }
}