public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _answers;

    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0)
    {
        _prompts = new List<string>();
        _answers = new List<string>();
    }
}
