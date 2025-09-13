using System;
class Program
{
    static void Main(string[] args)
    {
        // Using no-parameter constructor
        Fraction f1 = new Fraction();
        Console.WriteLine("Fraction f1 (no-parameter constructor):");
        Console.WriteLine("String: " + f1.GetFractionString());
        Console.WriteLine("Decimal: " + f1.GetDecimalValue());
        Console.WriteLine();

        // Using one-parameter constructor
        Fraction f2 = new Fraction(5);
        Console.WriteLine("Fraction f2 (one-parameter constructor):");
        Console.WriteLine("String: " + f2.GetFractionString());
        Console.WriteLine("Decimal: " + f2.GetDecimalValue());
        Console.WriteLine();

        // Using two-parameter constructor
        Fraction f3 = new Fraction(8, 12);
        Console.WriteLine("Fraction f3 (two-parameter constructor):");
        Console.WriteLine("Original string: " + f3.GetFractionString());
        Console.WriteLine("Original decimal: " + f3.GetDecimalValue());

        // Simplify f3
        f3.Simplify();
        Console.WriteLine("Simplified string: " + f3.GetFractionString());
        Console.WriteLine("Simplified decimal: " + f3.GetDecimalValue());
        Console.WriteLine();

        // Using setters to update f3
        f3.SetNumerator(30);
        f3.SetDenominator(60);
        Console.WriteLine("Updated f3 using setters:");
        Console.WriteLine("String: " + f3.GetFractionString());
        Console.WriteLine("Decimal: " + f3.GetDecimalValue());

        f3.Simplify();
        Console.WriteLine("Simplified updated f3:");
        Console.WriteLine("String: " + f3.GetFractionString());
        Console.WriteLine("Decimal: " + f3.GetDecimalValue());
    }
}



