using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        List<int> verses = new List<int>();
        verses.Add(5);
        verses.Add(6);
        Reference scriptureReference = new Reference("Proverbs", 3, verses);
        Scripture proverbs = new Scripture(scriptureReference, scriptureText);

        while (userInput != "quit")
        {
            int n = 0;
            foreach(Word word in proverbs.GetScriptureText())
            {
                if(word.GetWord().Contains("_"))
                {
                    n++;
                }
                
            }
            
            Console.Clear();
            Console.WriteLine(proverbs.GetScriptureString());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            if(n == proverbs.GetScriptureText().Count)
            {
                userInput = "quit";
            }

            if(userInput != "quit")
            {
                proverbs.HideWords();
            }
            
        }        
    }
}