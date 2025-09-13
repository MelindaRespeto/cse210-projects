using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructors
    public Fraction() // No-parameter constructor (1/1)
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int numerator) // One-parameter constructor (numerator/1)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    public Fraction(int numerator, int denominator) // Two-parameter constructor
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Getters and setters
    public int GetNumerator() => numerator;
    public void SetNumerator(int numerator) => this.numerator = numerator;

    public int GetDenominator() => denominator;
    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");
        this.denominator = denominator;
    }

    // Display fraction
    public void Display() => Console.WriteLine($"{numerator}/{denominator}");

    // Simplify fraction
    public void Simplify()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    // Returns fraction as string (e.g., "3/4")
    public string GetFractionString() => $"{numerator}/{denominator}";

    // Returns decimal value (e.g., 0.75)
    public double GetDecimalValue() => (double)numerator / denominator;

    // Greatest common divisor
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}

