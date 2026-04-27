using System;

class Program
{
    static void Main(string[] args)
    {
        while (true) {
        int guess = -1;
        Random rand = new Random();
        int magicNum = rand.Next(1,101);
        int attempts = 0;

        while (guess != magicNum)
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());
            if(guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
            attempts += 1;
        }
        Console.WriteLine($"You got it in {attempts} tries!");
        Console.Write("Would you like to play again (yes/no)? ");
        string answer = Console.ReadLine();
        if(answer == "no")
            {
              break;  
            }
        }
    }
}