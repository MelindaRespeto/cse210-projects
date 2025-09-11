using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new Fraction(8, 12);

        Console.Write("Original fraction: ");
        frac.Display();

        frac.Simplify();
        Console.Write("Simplified fraction: ");
        frac.Display();

        // Changing values using setters
        frac.SetNumerator(15);
        frac.SetDenominator(20);
        Console.Write("Updated fraction: ");
        frac.Display();

        frac.Simplify();
        Console.Write("Simplified updated fraction: ");
        frac.Display();
    }
}


