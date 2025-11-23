class Goals
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        Menu menu = new Menu();
        int choice = 0;

        Console.WriteLine("\nWelcome to the Eternal Quest Program!\n");

        while (choice != 6)
        {
            menu.DisplayMainMenu();
            choice = menu.GetMenuChoice();

            if (choice == 1)
            {
                // Create new goal
                Goal newGoal = menu.CreateGoal();
                goals.Add(newGoal);
                Console.WriteLine("Goal created!\n");
            }
            else if (choice == 2)
            {
                // List goals
                Console.WriteLine("\nYour Goals:");
                foreach (Goal g in goals)
                {
                    Console.WriteLine(g.GetStatus());
                }
                Console.WriteLine($"Current Score: {score}\n");
            }
            else if (choice == 3)
            {
                // Save goals
                Console.Write("Enter filename to save: ");
                string file = Console.ReadLine();
                SaveGoals(file, goals, score);
            }
            else if (choice == 4)
            {
                // Load goals
                Console.Write("Enter filename to load: ");
                string file = Console.ReadLine();
                (goals, score) = LoadGoals(file);
            }
            else if (choice == 5)
            {
                // Record event
                Console.WriteLine("\nWhich goal did you accomplish?");
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                }

                int goalIndex = int.Parse(Console.ReadLine()) - 1;

                int pointsEarned = goals[goalIndex].RecordEvent();
                score += pointsEarned;

                Console.WriteLine($"You earned {pointsEarned} points!");
                Console.WriteLine($"Total score: {score}\n");
            }
        }

        Console.WriteLine("Goodbye!");
    }

    // ---------------- SAVE / LOAD -------------------

    static void SaveGoals(string filename, List<Goal> goals, int score)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(score);

            foreach (Goal g in goals)
            {
                output.WriteLine(g.SaveString());
            }
        }

        Console.WriteLine("Goals saved!\n");
    }

    static (List<Goal>, int) LoadGoals(string filename)
    {
        List<Goal> loadedGoals = new List<Goal>();
        string[] lines = File.ReadAllLines(filename);

        int score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                loadedGoals.Add(new SimpleGoal(parts[1], "desc", int.Parse(parts[2])));
            }
            else if (type == "EternalGoal")
            {
                loadedGoals.Add(new EternalGoal(parts[1], "desc", int.Parse(parts[2])));
            }
            else if (type == "ChecklistGoal")
            {
                loadedGoals.Add(new ChecklistGoal(parts[1], "desc",
                    int.Parse(parts[2]),
                    int.Parse(parts[3]),
                    int.Parse(parts[4])));
            }
        }

        Console.WriteLine("Goals loaded!\n");
        return (loadedGoals, score);
    }
}
