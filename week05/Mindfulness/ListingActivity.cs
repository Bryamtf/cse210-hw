public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.Clear();
        GetRandomPrompt();
        Console.Write("\nYou may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");
    }
    public void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Start listing items (press Enter after each item):");
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                _count++;
            }
            if (DateTime.Now >= endTime)
                break;

        }

    }
}