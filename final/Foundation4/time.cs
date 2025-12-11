public class Time
{
    private int _hours;
    private int _minutes;
    private int _seconds;

    public Time(int h, int m, int s)
    {
        _hours = h;
        _minutes = m;
        _seconds = s;
    }

    public string GetFormatted()
    {
        return $"{_hours:D2}:{_minutes:D2}:{_seconds:D2}";
    }
}
