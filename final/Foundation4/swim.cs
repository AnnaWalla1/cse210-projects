public class Swim : Exercise
{
    private int _laps;

    public Swim(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceKm = (_laps * 50) / 1000.0;
        double miles = distanceKm * 0.62;
        return miles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string ToFileString()
    {
        return base.ToFileString() + $"|{_laps}";
    }
}
