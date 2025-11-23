public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override int RecordEvent()
    {
        return GetPoints(); // Never completes
    }

    public override string GetStatus()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }

    public override string SaveString()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}
