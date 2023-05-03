namespace ClockProject;

public class AnalogToDigitalClockAdapter : IDigitalClock
{
    private IAnalogClock _analogClock;

    public AnalogToDigitalClockAdapter(IAnalogClock analogClock)
    {
        _analogClock = analogClock ?? throw new ArgumentNullException(nameof(analogClock));
    }
    
    public void GetTime(out byte hours, out byte minutes)
    {
        ushort hourArrowDegree, minutesArrowDegree;
        _analogClock.GetTime(out hourArrowDegree, out minutesArrowDegree);

        hours = (byte)(hourArrowDegree / 30);
        minutes = (byte)(minutesArrowDegree / 6);
    }

    public void SetTime(byte hours, byte minutes)
    {
        _analogClock.SetTime((ushort)(hours * 30), (ushort)(minutes * 6));
    }
}