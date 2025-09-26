using System;

class Program
{
    static void Main(string[] args)
    {
        //create a MathAssignment object
        MathAssignment math =new MathAssignment("Maganda", "Fractions", "7.3", "10-20");
        Console. WriteLine(Math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        // Create a WritingAssignment object
        WritingAssignment writing = new WritingAssignment("Ghie", "History", "The Philippines Croc.");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
