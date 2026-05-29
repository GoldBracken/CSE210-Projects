public class Word
{
    private string _word;

    public void HideWord()
    {
        string hiddenWord = "";
        for (int i = 0; i < _word.Length; i++)
        {
            hiddenWord += "_";
        }
        _word = hiddenWord;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }
}