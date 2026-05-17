public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    //Iterates through _entries and prints each entry with a line break separating them.
    public void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e + "\n");
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(Entry e in _entries)
                {
                    outputFile.WriteLine($"{e._currDate}|{e._prompt}|{e._entry}");
                }
            }
    }

    public void LoadJournal(string fileName)
    {
                    string[] lines = System.IO.File.ReadAllLines(fileName);

                    //clears current values in Journal j so the loaded journal will populate j instead.
                    _entries.Clear();
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");

                        string eDate = parts[0];
                        string ePrompt = parts[1];
                        string eEntry = parts[2];

                        Entry entry = new Entry();
                        entry._currDate = eDate;
                        entry._prompt = ePrompt;
                        entry._entry = eEntry;
                        _entries.Add(entry);
                    }
    }
}