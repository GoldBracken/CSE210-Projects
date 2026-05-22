public class Scripture
{
  private List<Word> _text = new List<Word>();
  private Reference _reference;

  public Scripture(Reference reference)
    {
        _reference = reference;
    }

  public Scripture(Reference reference, string text)
    {
        _reference = reference;
        SetScriptureText(text);
    }

  public string GetScriptureTextString() {
    string words = "";
    foreach(Word word in _text)
        {
            words += word.GetWord() + " ";
        }
    return words;
  }

  public List<Word> GetScriptureText()
    {
        return _text;
    }

  public void SetScriptureText(string text) {
    string[] words = text.Split(" ");
    foreach(string word in words)
        {
            Word newWord = new Word();
            newWord.SetWord(word);
            _text.Add(newWord);
        }
  }

    public string GetReferenceString()
    {
        return _reference.GetReferenceString();
    }

    public void HideWords()
    {
        Random rand = new Random();
        for(int i = 0; i < 3; i++)
        {
            
            int index = 0;
            List<int> indexes = new List<int>();
            int n = 0;
            foreach(Word word in _text)
                {
                    if(!word.GetWord().Contains("_"))
                    {
                        indexes.Add(n);
                    }
                    n++;
                }
            index = indexes[rand.Next(0, indexes.Count - 1)];
            _text[index].HideWord();
            
           
        }
    }
}