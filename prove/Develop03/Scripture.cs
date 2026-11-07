using System;
using System.Collections.Generic;

namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _scripture = []; 

        string[] splitWords = text.Split(' ');
        foreach (string w in splitWords)
        {
            _scripture.Add(new Word(w));
        }
    }

    public void SelectAndHideThree()
    {
        Random random = new();
        int hiddenCount = 0;
        int targetHideCount = 3;

        while (hiddenCount < targetHideCount)
        {
            bool allHidden = true;
            foreach (Word w in _scripture)
            {
                if (w.IsHidden()) { allHidden = false; break; }
            }
            if (allHidden) break;

            int index = random.Next(_scripture.Count);
            if (!_scripture[index].IsHidden())
            {
                _scripture[index].Hide();
                hiddenCount++;
            }
        }
    }

    public void Display()
    {
        _reference.Display();
        Console.WriteLine("\n");
        foreach (Word word in _scripture)
        {
            word.Display();
        }
        Console.WriteLine();
    }
}