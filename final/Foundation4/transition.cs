public class Transition
{
    private string _name;
    private int _timeSeconds;

    public Transition(string name, int time)
    {
        _name = name;
        _timeSeconds = time;
    }

    public string GetInfo()
    {
        return $"{_name} transition — {_timeSeconds} seconds";
    }
}
