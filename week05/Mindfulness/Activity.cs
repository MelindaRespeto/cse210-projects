using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Starting message
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(5);
    }

    // Ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowSpinner(5);
    }

    // Spinner animation
    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    // Countdown animation
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }
}
