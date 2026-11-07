using System;

namespace ScriptureMemorizer;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }

    public void Hide() => _isHidden = true;

    public void SetWord(string word) => _word = word;

    public bool IsHidden() => _isHidden;

    public void Display()
    {
        if (_isHidden)
        {
            Console.Write(new string('_', _word.Length) + " ");
        }
        else
        {
            Console.Write(_word + " ");
        }
    }
}