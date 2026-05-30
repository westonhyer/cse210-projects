using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayTxt()
    {
        if (_isHidden)
    {
        string hiddenWord = new string('_', _text.Trim().Length);

        if (_text.StartsWith("\n"))
        {
            return "\n" + hiddenWord;
        }

        return hiddenWord;
    }

        return _text;
    }

    public string GetText()
    {
        return _text;
    }
}