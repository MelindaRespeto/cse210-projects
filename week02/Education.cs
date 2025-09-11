using System;

public class Education
{
    public string Degree { get; set; }
    public string School { get; set; }
    public int YearGraduated { get; set; }

    public void DisplayEducation()
    {
        Console.WriteLine($"{Degree} - {School} ({YearGraduated})");
    }
}
