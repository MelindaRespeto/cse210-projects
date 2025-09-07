using System;

class Program
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Job job1 = new Job();
        job1._jobTitle = "Teacher Assistant";
        job1._company = "Department of Education";
        job1._startYear = 2022;
        job1._endYear = 2024;
        job2._jobTitle = "Qaulity Assurance";
        job2._company = "Astec Company";
        job2._startYear = 2019;
        job2._endYear = 2020;

    public void DisplayJobDetails()

    {   Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();


        
    }
    
    }
