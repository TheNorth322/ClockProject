namespace ClockProject;

public class AnalogClock : IAnalogClock
{
    private ushort _minuteArrowDegree;
    private ushort _hourArrowDegree;

    public AnalogClock(ushort hourArrowDegree, ushort minuteArrowDegree)
    {
        _hourArrowDegree = hourArrowDegree;
        _minuteArrowDegree = minuteArrowDegree;
    }
    public string GetTime()
    {
        int hours = _hourArrowDegree / 30, minutes = _minuteArrowDegree / 6;
        return $"{hours}:{minutes}";
    }
}