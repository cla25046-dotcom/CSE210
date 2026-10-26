
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(saveFilename))
                    {
                        journal.SaveToFile(saveFilename);
                    }
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(loadFilename))
                    {
                        try
                        {
                            journal.LoadFromFile(loadFilename);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Could not load file: {ex.Message}");
                        }
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }
        }
    }
}
