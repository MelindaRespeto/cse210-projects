using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing items.") { }

    public override void Run()
    {
        Start();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt:\n--- {prompt} ---");

        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(5);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        End();
    }
}

