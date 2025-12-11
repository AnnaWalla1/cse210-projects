public class RaceDone
{
    private string _raceName;
    private double _distance;

    public RaceDone(string name, double distance)
    {
        _raceName = name;
        _distance = distance;
    }

    public string GetInfo()
    {
        return $"{_raceName} — { _distance } miles";
    }
}
