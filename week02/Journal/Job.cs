using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} at {_company} ({_startYear} - {_endYear})");
    }
}
Resume.cs:

csharp
Copy code
using System;
using System.Collections.Generic;

public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; } = new List<Job>();

    public Resume(string name)
    {
        Name = name;
    }

    public void AddJob(Job job)
    {
        Jobs.Add(job);
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Resume of {Name}");
        foreach (var job in Jobs)
        {
            job.Display();
        }
    }
}