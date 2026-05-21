using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(3);
        Fraction frac3 = new Fraction(2,7);

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac3.GetFractionString());

        frac1.SetDenominator(3);
        frac2.SetDenominator(4);
        frac3.SetNumerator(5);

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac3.GetFractionString());

        Console.WriteLine(frac2.GetDecimalValue());
        Console.WriteLine(frac3.GetDecimalValue());

        
        Random rand = new Random();

        for(int i = 0; i < 25; i++)
        {
            Fraction fraction = new Fraction();
            int top = rand.Next(1, 100);
            int bottom = rand.Next(1, 100);
            fraction.SetNumerator(top);
            fraction.SetDenominator(bottom);
            Console.WriteLine($"Fraction {i + 1}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue()}");
        }
    }
}