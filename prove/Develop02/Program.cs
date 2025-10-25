using System;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> entries = new List<Entry>();
        Journal journal = new Journal();
        Console.WriteLine("\nWelcome to the journal program. ");
        Console.WriteLine("\nPlease pick an option: ");

        int userChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. New Journal entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Read journal from file");
            Console.WriteLine("4. Write journal to file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Entry entry = new Entry();
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

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //Console.WriteLine("Hello Develop02 World!");
//         Entry myEntry = new Entry();
//         myEntry._givenPrompt = "What was the best part of my day?";
//         myEntry._entryDateTime = "Oct 6 2025";
//         myEntry._entryText = "waking up with Pero in my cup";
//         // myEntry.Display();
//         Entry anotherEntry = new Entry();
//         anotherEntry._givenPrompt = "Favorite GC talk?";
//         anotherEntry._entryDateTime = "Oct 5 2025";
//         anotherEntry._entryText = "Elder Amos' talk";

//         Journal myJournal = new Journal();
//         myJournal.Initialize();
//         myJournal.AppendEntry(myEntry);
//         myJournal.AppendEntry(anotherEntry);
//         myJournal.Display();
//     }
// }