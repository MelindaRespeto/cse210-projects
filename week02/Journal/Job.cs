using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is My Journal Project.");

        Job job1 = new Job();
        job1._jobTitle = "Teacher Assistant";
        job1._company = "Department of Education";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job(); job2._jobTitle = "Quality Assurance";
        job2._company = "Astec Company"; 
        job2._startYear = 2019; 
        job2._endYear = 2020;

        job1.Display();
        job2.Display
    }
}

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Method to display the job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
