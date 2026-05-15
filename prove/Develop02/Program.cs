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
        int _userChoice = -1;
        Random _rand = new Random();

        List<string> _prompts = ["What was the thing I most enjoyed doing today?", "What do I wish I could have done better today?",
        "What miracle did I see today?", "Who did I help today?", "What was something I think I did well today?", "What was I grateful for today?"];
        
        string _currentDate = $"{DateTime.Now.Month}/{DateTime.Now.Day}/{DateTime.Now.Year}";
        Journal _j = new Journal();
        Entry _userEntry = new Entry();

        List<string> _journals = new List<string>();
        string[] _files = System.IO.Directory.GetFiles("./", "*.txt");
        foreach(string file in _files)
        {
            _journals.Add(file.Split("/")[1].Split(".")[0]);
        }
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
                    _userEntry._prompt = _prompts[_rand.Next(_prompts.Count)];
                    _userEntry._currDate = _currentDate;
                    _userEntry.WriteEntry();
                    _j._entries.Add(_userEntry);
                    break;

                //Calls the DisplayEntries method on Journal _j and displays all entries to console.
                case 2:
                    _j.DisplayEntries();
                    break;

                //Asks user for journal name. Reads the given journal name and overrides current journal
                //with entry values saved in the given file on each line.
                case 3:
                    Console.WriteLine("Which journal would you like to load? ");

                    //Displays options for which journals are available to load
                    for(int i = 0; i < _journals.Count(); i++)
                    {
                        Console.WriteLine($"{_journals[i]}");
                    }

                    //Takes user inputted string and adds proper extension to use as file name.
                    _fileName = Console.ReadLine() + ".txt";
                    _lines = System.IO.File.ReadAllLines(_fileName);

                    //clears current values in Journal _j so the loaded journal will populate _j instead.
                    _j._entries.Clear();
                    foreach (string line in _lines)
                    {
                        string[] parts = line.Split("|");

                        string _eDate = parts[0];
                        string _ePrompt = parts[1];
                        string _eEntry = parts[2];

                        Entry _entry = new Entry();
                        _entry._currDate = _eDate;
                        _entry._prompt = _ePrompt;
                        _entry._entry = _eEntry;
                        _j._entries.Add(_entry);
                    }
                    break;

                //Asks for file name from user. Searches for file, creates one with user name if it doesn't
                //already exist. Iterates through Journal _j entries, writing each entry as a date|prompt|entry
                //on each line.
                case 4:
                    //User inputs file name which is then added to _journals and given the ".txt" type in the _fileName variable
                    Console.WriteLine("What is the file name? (Example: journal1)");
                    _fileName = Console.ReadLine();
                    string journalName = _fileName;
                    _fileName += ".txt";
                    _journals.Add(journalName);
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