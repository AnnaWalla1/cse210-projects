using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi friends!");
        Entry myEntry = new Entry();
        myEntry._givernPrompt = "How's your day going?";
        myEntry._entryDateTime = "Oct 6th 2025";
        myEntry._entryText = "good, except I;m tired";
        myEntry._Display();
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