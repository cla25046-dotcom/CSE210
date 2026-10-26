
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who was the most interesting person I talked to today?",
        "How did I see the hand of the Lord in my life today?",
        "What was something new I learned today?",
        "What is one thing I am grateful for today?",
        "What is something I could improve tomorrow?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine() ?? "";

        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);

        Console.WriteLine("Entry added!");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}
