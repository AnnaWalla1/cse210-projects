class Menu
{
    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
                new BreathActivity().Run();
            else if (choice == "2")
                new ReflectActivity().Run();
            else if (choice == "3")
                new ListeningActivity().Run();
            else if (choice == "4")
                break;
            else
            {
                Console.WriteLine("Invalid option. Try again.");
                Thread.Sleep(1500);
            }
        }
    }
}
