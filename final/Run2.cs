public class Run : Activity
{
    private double _distance; // miles

    public Run(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
}
