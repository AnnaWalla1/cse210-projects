using System;
using System.Collections.Generic;
using System.IO;

public class ActivityManager
{
    private List<Exercise> _activities = new List<Exercise>();

    public void AddActivity(Exercise activity)
    {
        _activities.Add(activity);
    }

    public Exercise CreateActivity()
    {
        Console.WriteLine("\nChoose activity type:");
        Console.WriteLine("1. Run");
        Console.WriteLine("2. Bike");
        Console.WriteLine("3. Swim");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Date (e.g. 03 Nov 2022): ");
        string date = Console.ReadLine();

        Console.Write("Minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Distance (miles): ");
            double d = double.Parse(Console.ReadLine());
            return new Run(date, minutes, d);
        }
        else if (choice == 2)
        {
            Console.Write("Speed (mph): ");
            double s = double.Parse(Console.ReadLine());
            return new Bike(date, minutes, s);
        }
        else
        {
            Console.Write("Laps: ");
            int laps = int.Parse(Console.ReadLine());
            return new Swim(date, minutes, laps);
        }
    }

    public void DisplayActivities()
    {
        Console.WriteLine("\n===== Your Training Log =====\n");

        foreach (Exercise a in _activities)
        {
            Console.WriteLine(a.GetSummary());
        }

        Console.WriteLine();
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Exercise a in _activities)
            {
                sw.WriteLine(a.ToFileString());
            }
        }

        Console.WriteLine("Saved!");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _activities.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Exercise ex = Exercise.FromFileString(line);
            if (ex != null)
                _activities.Add(ex);
        }

        Console.WriteLine("Loaded!");
    }
}
