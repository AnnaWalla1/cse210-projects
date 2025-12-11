public class Goal
{
    private string _goalName;
    private double _targetMiles;

    public Goal(string goalName, double targetMiles)
    {
        _goalName = goalName;
        _targetMiles = targetMiles;
    }

    public string GetGoal() => $"{_goalName} — Target: {_targetMiles} miles";
}
