using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -1;

        while(userChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activiy");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    Breathing breathingActiviy = new Breathing(0);
                    breathingActiviy.StartingMessage();
                    breathingActiviy.BreathingExercise();                    
                    break;
                case 2:
                    Reflection reflectionActiviy = new Reflection(0);
                    reflectionActiviy.StartingMessage();
                    reflectionActiviy.ReflectionExercise();
                    break;
                case 3: 
                    Listening listeningActiviy = new Listening(0);
                    listeningActiviy.StartingMessage();
                    listeningActiviy.ListeningExercise();
                    break;
            }
        }

        
        

        
    }
}