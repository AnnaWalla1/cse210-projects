using System;
using System.Threading;
using System.Collections.Generic;

class Activities
{
    // Attributes
    private string _intro;
    private string _description;
    private string _endMessage;
    private int _secondCount;
    private int _pause;

    // Constructor
    public Activities(string intro, string description)
    {
        _intro = intro;
        _description = description;
        _endMessage = "Good job! You’ve completed this mindfulness activity.";
        _secondCount = 0;
        _pause = 3;
    }

    // Common behaviors
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(_intro);
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like your session to last? ");
        _secondCount = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(_pause);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n" + _endMessage);
        ShowSpinner(2);
        Console.WriteLine($"You completed this activity for {_secondCount} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _secondCount;
    }
}
