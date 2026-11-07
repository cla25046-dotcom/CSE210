using System;

namespace ScriptureMemorizer;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;
    }

    public void SetBook(string book) => _book = book;
    public void SetChapter(int chapter) => _chapter = chapter;
    public void SetStartVerse(int startVerse) => _startVerse = startVerse;
    public void SetEndVerse(int endVerse) => _endVerse = endVerse;

    public void Display()
    {
        if (_endVerse > 0)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
        else
        {
            Console.Write("{_book} {_chapter}:{_startVerse}");
        }
    }
}