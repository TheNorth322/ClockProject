namespace ClockProject;

public interface IDigitalClock
{
    void GetTime(out byte hours, out byte minutes);
    void SetTime(byte hours, byte minutes);
}