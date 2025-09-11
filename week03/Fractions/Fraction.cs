using System;

public class Fraction
{
    // Private attributes
    private int numerator;   // top number
    private int denominator; // bottom number

    // Constructor
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Getter and Setter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int value)
    {
        numerator = value;
    }

    // Getter and Setter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int value)
    {
        if (value == 0)
            throw new ArgumentException("Denominator cannot be zero.");
        denominator = value;
    }

    // Display the fraction
    public void Display()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

    // Simplify the fraction
    public void Simplify()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    // Helper method to calculate GCD
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
