using System;
using System.Threading;

public abstract class Activity
{
    // Shared fields
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Common methods
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine($"\nWell done! You completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] sequence = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(sequence[i]);
            Thread.Sleep(200);
            Console.Write("\b \b"); // backspace to clear
            i = (i + 1) % sequence.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // erase number
        }
    }

    // Each derived class implements Run
    public abstract void Run();
}
