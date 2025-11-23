using System;
using System.Collections.Generic;

public class Menu
{
    public void DisplayMainMenu()
    {
        Console.WriteLine("\n=== Eternal Quest Menu ===");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record an Event");
        Console.WriteLine("6. Quit");
    }

    public int GetMenuChoice()
    {
        Console.Write("Choose an option: ");
        return int.Parse(Console.ReadLine());
    }

    public Goal CreateGoal()
    {
        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            return new SimpleGoal(name, description, points);
        }
        else if (type == 2)
        {
            return new EternalGoal(name, description, points);
        }
        else
        {
            Console.Write("How many times to complete this goal? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus for completing: ");
            int bonus = int.Parse(Console.ReadLine());

            return new ChecklistGoal(name, description, points, target, bonus);
        }
    }
}
