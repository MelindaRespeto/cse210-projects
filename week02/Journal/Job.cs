using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Job job1 = new Job();
        job1._jobTitle = "Teacher Assistant";
        job1._company = "Department of Education";
        job1._startYear = 2022;
        job1._endYear = 2024;

        job1.Display();
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
