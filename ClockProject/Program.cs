using ClockProject;

public static class Program
{
    public static void Main()
    {
        TimeChecker timeChecker = new TimeChecker();
        IDigitalClock digitalClock = new DigitalClock(12, 30);
        IDigitalClock adapter = new AnalogToDigitalClockAdapter(new AnalogClock(360, 180));
        Console.WriteLine(timeChecker.CheckTime(digitalClock));
        Console.WriteLine(timeChecker.CheckTime(adapter));
    }
}