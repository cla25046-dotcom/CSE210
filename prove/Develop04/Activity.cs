public class Activity

{
    private string _name;

    private string _description;

    private int _duration;


    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void showProlgue()
    {
        Console.WriteLine("Welcome to the Mindfulness activity!");
    }

    public void showSpinner()
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        Console.WriteLine("Hope you enjoyed the activity");
    }

    public void showEpiologue()
    {
        
    }

    public void showTimedMessage()
    {
        
    }

    public void checkTimer()
    {
        
    }








}