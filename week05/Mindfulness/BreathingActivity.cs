public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        int breathInTime = 4;
        int breathOutTime = 6;
        int totalBreathTime = breathInTime + breathOutTime;
        while (DateTime.Now < endTime)
        {
            double remainingSeconds = (endTime - DateTime.Now).TotalSeconds;
            if (remainingSeconds < totalBreathTime)
                break;
            Console.Clear();
            Console.Write("Breathe in...");
            ShowCountDown(breathInTime);

            Console.Clear();
            Console.Write("Now breathe out...");

            ShowCountDown(breathOutTime);
        }
        Console.WriteLine();
        DisplayEndingMessage();

    }
}