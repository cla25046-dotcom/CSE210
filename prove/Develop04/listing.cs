
using System;
using System.Collections.Generic;
using System.Threading;



public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _answers;

    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _answers = new List<string>();
    }

    public override void RunActivity()
    {
        showProlgue();

        Random rand = new Random();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("You may begin in:");
        showTimedMessage();

        Console.WriteLine();
        Console.Write("Enter your responses, pressing Enter after each one. Press Enter on a blank line to finish: ");
        while (true)
        {
            string answer = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(answer))
            {
                break;
            }

            _answers.Add(answer);
        }

        Console.WriteLine($"You listed {_answers.Count} items!");
        showEpiologue();
    }
}
