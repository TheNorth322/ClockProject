namespace ClockProject;

public class DigitalClock : IDigitalClock
{
    private byte _hours;
    private byte _minutes;

    public DigitalClock(byte hours, byte minutes)
    {
        SetTime(hours, minutes);        
    }
    
    public void SetTime(byte hours, byte minutes)
    {
        ValidateTime(hours, minutes);
        _hours = hours;
        _minutes = minutes;
    }

    public void GetTime(out byte hours, out byte minutes)
    {
        hours = _hours;
        minutes = _minutes;
    } 
    
    private void ValidateTime(byte hours, byte minutes)
    {
        if (hours < 0 || hours > 24)
            throw new ArgumentException(nameof(hours));
        if (minutes < 0 || minutes > 60)
            throw new ArgumentException(nameof(minutes));
    }
}