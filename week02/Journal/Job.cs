using System;

public class Job
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }
    public string Description { get; set; }

    public void DisplayJob()
    {
        Console.WriteLine($"{JobTitle,-30} {Company,-30} {StartYear}-{EndYear}");
        Console.WriteLine($"   {Description}");
    }
}
