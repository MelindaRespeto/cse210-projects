using System;
using System.Collections.Generic;

public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; } = new List<Job>();
    public List<Education> Educations { get; } = new List<Education>();
    public List<string> Skills { get; } = new List<string>();

    public Resume(string name)
    {
        Name = name;
    }

    public void AddJob(Job job) => Jobs.Add(job);
    public void AddEducation(Education edu) => Educations.Add(edu);
    public void AddSkill(string skill) => Skills.Add(skill);

    public void DisplayResume()
    {
        Console.WriteLine("========== RESUME ==========\n");

        Console.WriteLine("Education:");
        Console.WriteLine("----------");
        foreach (var edu in Educations)
        {
            edu.DisplayEducation();
        }

        Console.WriteLine("Work Experience:");
        Console.WriteLine("----------------");
        Console.WriteLine($"{"Job Title",-30} {"Company",-30} Duration");
        Console.WriteLine(new string('-', 70));
        foreach (Job job in Jobs)
        {
            job.DisplayJob();
        }

        Console.WriteLine("Skills:");
        Console.WriteLine("-------");
        foreach (var skill in Skills)
        {
            Console.WriteLine($"- {skill}");
        }

        Console.WriteLine("\n=============================");
    }
}