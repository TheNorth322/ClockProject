namespace ClockProject;

public interface IAnalogClock
{
    void GetTime(out ushort hourArrowDegree, out ushort minuteArrowDegree);
    void SetTime(ushort hourArrowDegree, ushort minuteArrowDegree);
}