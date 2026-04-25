using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percent grade (ex: 89)? ");
        string n = Console.ReadLine();
        int grade = int.Parse(n);

        bool passed = true;
        string letter = "";

        if (grade >= 90) 
        {
           letter = "A";
        }
        else if (grade >= 80) 
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60) 
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
        }

        if(grade%10 >= 7 && letter != "F" && letter != "A")
        {
            letter = letter + "+";
        }
        else if (grade%10 < 3 && letter != "F")
        {
            letter = letter + "-";
        }

        Console.WriteLine($"You got a {letter}");

        if(passed)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but you still learned! You'll do better next time.");
        }
    }
}