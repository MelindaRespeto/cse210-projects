using System;

public class Education
{
    public string Degree { get; set; }
    public string School { get; set; }
    public int YearGraduated { get; set; }

    public void DisplayEducation()
    {
        Console.WriteLine($"{Degree,-45} {YearGraduated}");
        Console.WriteLine($"{School,-45}");
        Console.WriteLine();
    }
}