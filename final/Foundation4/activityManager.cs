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
        Console.WriteLine("\nSelect activity type:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Cycling");
        Console.WriteLine("3. Swimming");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter date (e.g. 03 Nov 2022): ");
        string date = Console.ReadLine();

        Console.Write("Enter time in minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter distance (miles): ");
            double miles = double.Parse(Console.ReadLine());
            return new Run(date, minutes, miles);
        }
        else if (choice == 2)
        {
            Console.Write("Enter speed (mph): ");
            double speed = double.Parse(Console.ReadLine());
            return new Bike(date, minutes, speed);
        }
        else
        {
            Console.Write("Enter number of laps: ");
            int laps = int.Parse(Console.ReadLine());
            return new Swim(date, minutes, laps);
        }
    }

    public void DisplayActivities()
    {
        Console.WriteLine("\nYour Activities:\n");
        foreach (var a in _activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var a in _activities)
            {
                writer.WriteLine(a.ToFileString());
            }
        }

        Console.WriteLine("Activities saved!");
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
            Exercise activity = Exercise.FromFileString(line);
            _activities.Add(activity);
        }

        Console.WriteLine("Activities loaded!");
    }
}
