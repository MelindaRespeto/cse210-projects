using System;

public class PersonalData
{
    public string FullName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public void DisplayPersonalData()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("           [Photo Here]");
        Console.WriteLine("=====================================");
        Console.WriteLine($"             {FullName.ToUpper()}");
        Console.WriteLine("=====================================");
        Console.WriteLine($"{"Address:",-10} {Address}");
        Console.WriteLine($"{"Age:",-10} {Age}");
        Console.WriteLine($"{"Email:",-10} {Email}");
        Console.WriteLine($"{"Phone:",-10} {Phone}");
        Console.WriteLine();
    }
}
