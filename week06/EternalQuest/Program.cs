using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        // ✅ Automatically load saved goals when the program starts
        if (File.Exists("goals.txt"))
        {
            LoadGoals(goals, ref totalPoints);
            Console.WriteLine("\n✅ Goals and score loaded automatically!");
        }
        else
        {
            Console.WriteLine("\n📁 No saved goals found. Starting fresh.");
        }

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Goal Tracker ===");
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;

                case "2":
                    if (goals.Count == 0)
                    {
                        Console.WriteLine("No goals available.");
                        break;
                    }
                    Console.WriteLine("\nSelect goal to record:");
                    for (int i = 0; i < goals.Count; i++)
                        Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                    Console.Write("Enter number: ");
                    int num = int.Parse(Console.ReadLine()) - 1;
                    if (num >= 0 && num < goals.Count)
                        totalPoints += goals[num].RecordEvent();
                    break;

                case "3":
                    Console.WriteLine("\nYour Goals:");
                    foreach (var g in goals)
                        g.DisplayGoal();
                    break;

                case "4":
                    SaveGoals(goals, totalPoints);
                    break;

                case "5":
                    // ✅ Auto-save before exit (optional but nice)
                    SaveGoals(goals, totalPoints);
                    Console.WriteLine("Progress saved. Goodbye!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();

        if (type == "1")
        {
            Console.Write("Enter points: ");
            int pts = int.Parse(Console.ReadLine());
            goals.Add(new SimpleGoal(name, desc, pts));
        }
        else if (type == "2")
        {
            Console.Write("Enter points per record: ");
            int pts = int.Parse(Console.ReadLine());
            goals.Add(new EternalGoal(name, desc, pts));
        }
        else if (type == "3")
        {
            Console.Write("Enter points per action: ");
            int pts = int.Parse(Console.ReadLine());
            Console.Write("Enter required completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
        }

        Console.WriteLine("Goal added successfully!");
    }

    static void SaveGoals(List<Goal> goals, int totalPoints)
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal g in goals)
                outputFile.WriteLine(g.GetStringRepresentation());
        }
        Console.WriteLine("💾 Goals saved successfully!");
    }

    static void LoadGoals(List<Goal> goals, ref int totalPoints)
    {
        goals.Clear();
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("⚠ No saved goals found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal sg = new SimpleGoal(name, desc, points);
                if (isComplete)
                {
                    // Simulate marking complete
                    sg.RecordEvent();
                }
                goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int current = int.Parse(parts[6]);
                goals.Add(new ChecklistGoal(name, desc, points, target, bonus, current));
            }
        }
    }
}

