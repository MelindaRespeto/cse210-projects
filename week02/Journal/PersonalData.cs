using System;
using System.Collections.Generic;
using System.IO;

public class ProgramData
{
    private List<Job> _entries;
    private List<string> _prompts;
    private Random _random;

    public ProgramData()
    {
        _entries = new List<Job>();
        _random = new Random();

        _prompts = new List<string>
        {
            "What made you smile today?",
            "What is one challenge you overcame?",
            "Write about something you learned today.",
            "Who made a difference in your life today?",
            "What are you grateful for right now?"
        };
    }

    public void AddEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();
        Job newEntry = new Job(date, prompt, response);
        _entries.Add(newEntry);

        Console.WriteLine("Entry added successfully!\n");
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\n=== Journal Entries ===");
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
        }
        else
        {
            foreach (Job entry in _entries)
            {
                Console.WriteLine(entry.GetEntryDetails());
                Console.WriteLine("---------------------------");
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Job entry in _entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
        Console.WriteLine($"Journal saved to {fileName}.\n");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Job entry = Job.FromFileFormat(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded from {fileName}.\n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }
}


