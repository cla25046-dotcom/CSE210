public abstract class Activity
{
    protected string _name;

    protected string _description;

    protected int _duration;


    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public abstract void RunActivity();

    public void showProlgue()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter the time of the activity in seconds: ");

        string input = Console.ReadLine();
        if (int.TryParse(input, out int parsedDuration))
        {
            _duration = parsedDuration;
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a whole number.");
        }

        Console.Clear();
        Console.WriteLine("Get ready!!!");
        showSpinner();
    }

    public void showSpinner()
    {
    List<string> animationString = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3); 

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("  ");
            i = (i + 1) % animationString.Count;
        }
    }

    public void showEpiologue()
    {
        Console.WriteLine("Great job!!");
        showSpinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        showSpinner();
    }

    public void showTimedMessage()
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write(" ");
        }
    }

    public bool checkTimer(DateTime startTime, DateTime endTime)
    {
        DateTime currentTime = DateTime.Now;
        return currentTime < endTime;

    }
    public int GetDuration()
    {
        return _duration;
    }

    public void ShowStartingMessage()
    {
        showProlgue();
    }

    public void ShowEndingMessage()
    {
        showEpiologue();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("  ");
        }
    }








}