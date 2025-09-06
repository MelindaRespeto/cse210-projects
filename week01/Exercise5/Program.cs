using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");

        
        Console.Write("Please enter your favorite number: ");
        string numberInput = Console.ReadLine();

        int favoriteNumber;
        if (int.TryParse(numberInput, out favoriteNumber))
        {
            int square = favoriteNumber * favoriteNumber;
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        else
        {
            Console.WriteLine("Invalid number entered. Please enter a valid integer.");
        }
    }
}
