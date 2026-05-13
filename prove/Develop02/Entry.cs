public class Entry
{
    public string _prompt;
    public string _currDate;
    public string _entry;

    //Asks the user based on current prompt for an entry, and updates _entry variable from user input.
    public void WriteEntry()
    {
        Console.WriteLine(_prompt);
        _entry = Console.ReadLine();
    }

    //Overrides the ToString() method so when written in the console, it is in a clean format.
    public override string ToString()
    {
        return $"Date: {this._currDate} - Prompt: {this._prompt}\n{this._entry}";
    }
}