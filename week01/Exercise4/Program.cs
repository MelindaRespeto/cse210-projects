using System;
using System.Collections.Generic; // Needed for List<T>
using System.Linq;                // Needed for Sum, Average, Max

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int largest = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
