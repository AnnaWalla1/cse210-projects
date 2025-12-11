using System;

public abstract class Exercise
{
    private string _date;
    private int _minutes;

    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min/mile";
    }

    // ---------- SAVE/LOAD SUPPORT ----------

    public virtual string ToFileString()
    {
        // base attributes only
        return $"{this.GetType().Name}|{_date}|{_minutes}";
    }

    public static Exercise FromFileString(string data)
    {
        string[] parts = data.Split('|');

        string type = parts[0];
        string date = parts[1];
        int minutes = int.Parse(parts[2]);

        if (type == "Run")
        {
            double distance = double.Parse(parts[3]);
            return new Run(date, minutes, distance);
        }
        else if (type == "Bike")
        {
            double speed = double.Parse(parts[3]);
            return new Bike(date, minutes, speed);
        }
        else if (type == "Swim")
        {
            int laps = int.Parse(parts[3]);
            return new Swim(date, minutes, laps);
        }

        return null;
    }
}
