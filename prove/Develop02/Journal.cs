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
}