/*
 Exceeding: Added a functionality where the user can now save the files by only giving a file name 
 instead of needing to include ".txt" in it (line 100-103). I modified the load case (case 3) to display 
 the existing journals that a user can choose from and load, again without needing to include 
 the ".txt" extension in the chosen journals name (line 67-74).
*/

using System;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -1;
        Random rand = new Random();

        List<string> prompts = ["What was the thing I most enjoyed doing today?", "What do I wish I could have done better today?",
        "What miracle did I see today?", "Who did I help today?", "What was something I think I did well today?", "What was I grateful for today?"];
        
        string currentDate = $"{DateTime.Now.Month}/{DateTime.Now.Day}/{DateTime.Now.Year}";
        Journal j = new Journal();
        Entry userEntry = new Entry();

        List<string> journals = new List<string>();
        string[] files = System.IO.Directory.GetFiles("./", "*.txt");
        foreach(string file in files)
        {
            journals.Add(file.Split("/")[1].Split(".")[0]);
        }
        string fileName = "myFile.txt";

        Console.WriteLine("Welcome to the Journal Program!");

        // Loops while the user has not chosen option 5.
        while(userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            // Switch case for the 5 options given to the user.
            switch (userChoice)
            {
                // Creates a new Entry and has the user populate it. Once all variables have been populated with
                //user-inputed values, it appends it to the entries list in Journal j.
                case 1:
                    userEntry = new Entry();
                    userEntry._prompt = prompts[rand.Next(prompts.Count)];
                    userEntry._currDate = currentDate;
                    userEntry.WriteEntry();
                    j._entries.Add(userEntry);
                    break;

                //Calls the DisplayEntries method on Journal j and displays all entries to console.
                case 2:
                    j.DisplayEntries();
                    break;

                //Asks user for journal name. Reads the given journal name and overrides current journal
                //with entry values saved in the given file on each line.
                case 3:
                    Console.WriteLine("Which journal would you like to load? ");

                    //Displays options for which journals are available to load
                    for(int i = 0; i < journals.Count(); i++)
                    {
                        Console.WriteLine($"{journals[i]}");
                    }

                    //Takes user inputted string and adds proper extension to use as file name.
                    fileName = Console.ReadLine() + ".txt";
                    j.LoadJournal(fileName);
                    break;

                //Asks for file name from user. Searches for file, creates one with user name if it doesn't
                //already exist. Iterates through Journal j entries, writing each entry as a date|prompt|entry
                //on each line.
                case 4:
                    //User inputs file name which is then added to journals and given the ".txt" type in the fileName variable
                    Console.WriteLine("What is the file name? (Example: journal1)");
                    fileName = Console.ReadLine();
                    string journalName = fileName;
                    fileName += ".txt";
                    journals.Add(journalName);
                    j.SaveJournal(fileName);
                    break;
                //Breaks out of loop
                case 5:
                    break;                      
            }
        }
    }
}