public class Run : Exercise
{
    private double _distanceMiles;

    public Run(string date, int minutes, double distanceMiles)
        : base(date, minutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance() => _distanceMiles;

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
        return base.ToFileString() + $"|{_distanceMiles}";
    }
}
