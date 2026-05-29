using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        
        practiceScripture();    
        
    }

    static void practiceScripture()
    {
        Console.Clear();
        string userInput = "";
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        List<int> verses = new List<int>();
        verses.Add(5);
        verses.Add(6);
        Reference scriptureReference = new Reference("Proverbs", 3, verses);
        Scripture proverbs = new Scripture(scriptureReference, scriptureText);
        scriptureReference = new Reference("John", 3, 16);
        Scripture john = new Scripture(scriptureReference, @"For God so loved the world, that he gave his only 
begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture moroni = new Scripture(new Reference("Moroni", 10, new List<int>() {3,5}), @"Behold, I would exhort you that when ye shall read these 
things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto 
the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder 
it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, 
in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having 
faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the 
Holy Ghost ye may know the truth of all things.");

        List<Scripture> scriptures = new List<Scripture>() {proverbs, john, moroni};
        Console.WriteLine("Choose a scripture to practice from: ");
        for(int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetReferenceString()}");
        }
        int userChoice = int.Parse(Console.ReadLine());

        Scripture userScripture = scriptures[0];
        userScripture = scriptures[userChoice - 1];

        while (userInput != "quit")
        {
            int n = 0;
            foreach(Word word in userScripture.GetScriptureText())
            {
                if(word.GetWord().Contains("_"))
                {
                    n++;
                }
                
            }
            
            Console.Clear();
            Console.WriteLine(userScripture.GetScriptureString());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            if(n == userScripture.GetScriptureText().Count)
            {
                userInput = "quit";
            }

            if(userInput != "quit")
            {
                userScripture.HideWords();
            } 
        }
        Console.WriteLine("Would you like to practice some more? Y/N");
        userInput = Console.ReadLine();
        if((userInput == "Y") || (userInput == "y"))
        {
            practiceScripture();
        }
    }
}