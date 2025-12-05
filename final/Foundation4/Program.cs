using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> activities = new List<Exercise>();
        ActivityManager manager = new ActivityManager();

        Console.WriteLine("\nWelcome to the Triathlon Training Tracker!");
        Console.WriteLine("\nPlease pick an option: ");

        int userChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Add new activity");
            Console.WriteLine("2. Display all activities");
            Console.WriteLine("3. Load activities from file");
            Console.WriteLine("4. Save activities to file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Exercise activity = manager.CreateActivity();
                manager.AddActivity(activity);
            }
            else if (userChoice == 2)
            {
                manager.DisplayActivities();
            }
            else if (userChoice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                manager.LoadFromFile(filename);
            }
            else if (userChoice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                manager.SaveToFile(filename);
            }

        } while (userChoice != 5);
    }
}
