namespace ClockProject;

public class AnalogClock : IAnalogClock
{
    private ushort _minuteArrowDegree;
    private ushort _hourArrowDegree;

    public AnalogClock(ushort minuteArrowDegree, ushort hourArrowDegree)
    {
        SetTime(hourArrowDegree, minuteArrowDegree); 
    }

    public void SetTime(ushort hourArrowDegree, ushort minuteArrowDegree)
    {
        ValidateTime(hourArrowDegree, minuteArrowDegree);
        _hourArrowDegree = hourArrowDegree;
        _minuteArrowDegree = minuteArrowDegree;
    }

    private void ValidateTime(ushort hourArrowDegree, ushort minuteArrowDegree)
    {
        if (hourArrowDegree < 0 || hourArrowDegree > 720)
            throw new ArgumentException(nameof(hourArrowDegree));
        if (minuteArrowDegree < 0 || minuteArrowDegree > 360)
            throw new ArgumentException(nameof(minuteArrowDegree));
    }

    public void GetTime(out ushort hourArrowDegree, out ushort minuteArrowDegree)
    {
        hourArrowDegree = _hourArrowDegree;
        minuteArrowDegree = _minuteArrowDegree;
    } 
}