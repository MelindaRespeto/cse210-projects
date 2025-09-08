using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Resume myResume = new Resume("Melinda");

        Job job1 = new Job("Teacher Assistant", "Department of Education", 2022, 2024);
        Job job2 = new Job("Quality Assurance", "Astec Company", 2019, 2020);

        myResume.AddJob(job1);
        myResume.AddJob(job2);

        myResume.DisplayResume();
    }
}