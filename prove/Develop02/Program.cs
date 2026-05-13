using System;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int _userChoice = -1;
        Random rand = new Random();

        List<string> _prompts = ["What was the thing I most enjoyed doing today?", "What do I wish I could have done better today?",
        "What miracle did I see today?", "Who did I help today?", "What was something I think I did well today?", "What was I grateful for today?"];
        
        string _currentDate = $"{DateTime.Now.Month}/{DateTime.Now.Day}/{DateTime.Now.Year}";
        Journal _j = new Journal();
        Entry _userEntry = new Entry();

        string _fileName = "myFile.txt";
        string[] _lines;

        Console.WriteLine("Welcome to the Journal Program!");

        // Loops while the user has not chosen option 5.
        while(_userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            _userChoice = int.Parse(Console.ReadLine());

            // Switch case for the 5 options given to the user.
            switch (_userChoice)
            {
                // Creates a new Entry and has the user populate it. Once all variables have been populated with
                //user-inputed values, it appends it to the _entries list in Journal _j.
                case 1:
                    _userEntry = new Entry();
                    _userEntry._prompt = _prompts[rand.Next(_prompts.Count)];
                    _userEntry._currDate = _currentDate;
                    _userEntry.WriteEntry();
                    _j._entries.Add(_userEntry);
                    break;

                //Calls the DisplayEntries method on Journal _j and displays all entries to console.
                case 2:
                    _j.DisplayEntries();
                    break;

                //Asks user for file name of journal. Reads the given file name and overrides current journal
                //with entry values saved in the given file on each line.
                case 3:
                    Console.WriteLine("What is the file name? ");
                    _fileName = Console.ReadLine();
                    _lines = System.IO.File.ReadAllLines(_fileName);
                    _j._entries.Clear();
                    foreach (string line in _lines)
                    {
                        string[] parts = line.Split("|");

                        string date = parts[0];
                        string prompt = parts[1];
                        string entry = parts[2];

                        Entry _entry = new Entry();
                        _entry._currDate = date;
                        _entry._prompt = prompt;
                        _entry._entry = entry;
                        _j._entries.Add(_entry);
                    }
                    break;

                //Asks for file name from user. Searches for file, creates one with user name if it doesn't
                //already exist. Iterates through Journal _j entries, writing each entry as a date|prompt|entry
                //on each line.
                case 4:
                    Console.WriteLine("What is the file name? ");
                    _fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(_fileName))
                    {
                        foreach(Entry e in _j._entries)
                        {
                            outputFile.WriteLine($"{e._currDate}|{e._prompt}|{e._entry}");
                        }
                    }
                    break;
                //Breaks out of loop
                case 5:
                    break;                      
            }
        }
    }
}