using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Journal journal = new Journal();
        Console.WriteLine("\nWelcome to the journal program. ");
        Console.WriteLine("\nPlease pick an option: ");

        int userChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. John 11:35");
            Console.WriteLine("2. 1st Nephi 17:51");
            Console.WriteLine("3. Alma 5:33");
            Console.WriteLine("4. Doctrine and Covenants 6:36");
            Console.WriteLine("5. Acts 2:3-4");
            Console.WriteLine("What would you like to do?");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Scripture entry = new Scripture();
                entry.getDate();
                entry.GetResponse();
                entries = journal.AddEntry(entry);
            }
            else if (userChoice == 2)
            {
                journal.Display();
            }
            else if (userChoice == 3)
            {
                Console.Write("Please enter the file name:");
                string filename = Console.ReadLine();
                journal.ReadFromFIle(filename);
            }
            else if (userChoice == 4)
            {
                Console.Write("Please enter the file name: ");
                string filename = Console.ReadLine();
                journal.WriteToFile(filename);
            }

        } while (userChoice != 5);
    }

}