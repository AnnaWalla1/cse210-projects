using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ActivityManager manager = new ActivityManager();
        int choice;

        Console.WriteLine("Welcome to the Triathlon Training Tracker!");

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Add new activity");
            Console.WriteLine("2. Display activities");
            Console.WriteLine("3. Load from file");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                var activity = manager.CreateActivity();
                manager.AddActivity(activity);
            }
            else if (choice == 2)
            {
                manager.DisplayActivities();
            }
            else if (choice == 3)
            {
                Console.Write("Filename: ");
                manager.LoadFromFile(Console.ReadLine());
            }
            else if (choice == 4)
            {
                Console.Write("Filename: ");
                manager.SaveToFile(Console.ReadLine());
            }

        } while (choice != 5);

        Console.WriteLine("Goodbye!");
    }
}
