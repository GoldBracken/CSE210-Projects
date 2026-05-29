public class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verses;

    public Reference(string book, int chapt, int verse)
    {
        _book = book;
        _chapter = chapt;
        _verses = new List<int> { verse };
    }

    public Reference(string book, int chapt, List<int> verse)
    {
        _book = book;
        _chapter = chapt;
        _verses = verse;
    }

    public string GetReferenceString()
    {
        if (_verses.Count == 1)
        {
            return $"{_book} {_chapter}:{_verses[0]}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verses[0]}-{_verses.Last()}";
        }

    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public List<int> GetVerses()
    {
        return _verses;
    }

    public void SetReferenceBook(string book)
    {
        _book = book;
    }

    public void SetReferenceChapter(int chapt)
    {
        _chapter = chapt;
    }

    public void SetReferenceVerses(List<int> verses)
    {
        _verses = verses;
    }
}