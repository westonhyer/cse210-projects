using System;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideWords(int count)
    {
        for (int i = 0; i < count; i++)
        {            
            List<int> notHidden = new List<int>();

            for (int j = 0; j < _words.Count; j++)
            {
                if (!_words[j].IsHidden())
                {
                    notHidden.Add(j);
                }
            }

            if (notHidden.Count>0)
            {
                int randomIndex = _random.Next(notHidden.Count);
                int index = notHidden[randomIndex];
                _words[index].Hide();
            }
        }
    }
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public string GetDisplayTxt()
    {
        string displayTxt = _reference.GetDisplayTxt();

        foreach (Word word in _words)
        {
             if (word.GetText() == "3." || word.GetText() == "4." || word.GetText() == "5.")
            {
                displayTxt += Environment.NewLine;
            }

        displayTxt += " " + word.GetDisplayTxt();
        }

    return displayTxt;
    }
}