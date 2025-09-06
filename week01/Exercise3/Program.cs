using System;

class Program
{
    static void Main(string[] args)
    {
        
        int magicNumber = 10; // The magic number
        int guess = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("What is the magic number?.");

        // Keep looping until the correct number is guessed
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}         
    

