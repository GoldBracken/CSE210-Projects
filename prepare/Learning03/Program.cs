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

        Console.WriteLine(frac1);
        Console.WriteLine(frac2);
        Console.WriteLine(frac3);

        Console.WriteLine(frac2.GetDecimalValue());
        Console.WriteLine(frac3.GetDecimalValue());

        
        Random rand = new Random();
        Fraction fraction = new Fraction();
        for(int i = 0; i < 25; i++)
        {
            
            int top = rand.Next(1, 100);
            int bottom = rand.Next(1, 100);
            fraction.SetNumerator(top);
            fraction.SetDenominator(bottom);
            Console.WriteLine($"Fraction {i + 1}: String: {fraction} Number: {fraction.GetDecimalValue()}");
        }
    }
}