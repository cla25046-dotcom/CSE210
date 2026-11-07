using System;

namespace ScriptureMemorizer;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        
        Scripture scripture = new(reference, text);

        string userInput = string.Empty;

        while (userInput != "quit")
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to finish:");
            userInput = Console.ReadLine()?.Trim().ToLower();

            if (userInput == "quit")
            {
                break;
            }

            scripture.SelectAndHideThree();
        }
    }
}