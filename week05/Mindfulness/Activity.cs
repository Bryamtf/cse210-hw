public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine($"\n{_description}");
        Console.Write($"\n How long, in seconds, would like for you session?");
        _duration = int.Parse(Console.ReadLine());

        /*Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);*/
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done !!");

        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        int iterations = seconds * 2;
        for (int i = 0; i < iterations; i++)
        {
            string s = animationStrings[i % animationStrings.Count];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }

    }


}