namespace ClockProject;

public class DigitalClock : IDigitalClock
{
    private byte _hours;
    private byte _minutes;

    public DigitalClock(byte hours, byte minutes)
    {
        _hours = hours;
        _minutes = minutes;
    }
    public string GetTime()
    {
        return $"{_hours}:{_minutes}";
    }
}