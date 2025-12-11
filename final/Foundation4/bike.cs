public class Bike : Exercise
{
    private double _speedMph;

    public Bike(string date, int minutes, double speedMph)
        : base(date, minutes)
    {
        _speedMph = speedMph;
    }

    public override double GetSpeed() => _speedMph;

    public override double GetDistance()
    {
        return (GetSpeed() * GetMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string ToFileString()
    {
        return base.ToFileString() + $"|{_speedMph}";
    }
}
