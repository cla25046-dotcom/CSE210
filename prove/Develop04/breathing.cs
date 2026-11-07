using System;


public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.",
        0)
    {
    }

    public override void RunActivity()
    {
        ShowStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        bool breatheIn = true;
        while (DateTime.Now < endTime)
        {
            if (breatheIn)
            {
                Console.Write("Breathe in... ");
                ShowCountDown(4);
            }
            else
            {
                Console.Write("Breathe out... ");
                ShowCountDown(6);
            }
            breatheIn = !breatheIn;
        }

        ShowEndingMessage();
    }
}