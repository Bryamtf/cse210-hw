public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How many times did you day 'I love you'?",
        "What new thing did you learn today that's new?",
        "What are you grateful for today?",
        "What challenged me today and how did I grow from it?",
        "What made me feel proud of myself today?",
        "If today were a chapter in my life, what would it be titled?",
        "When did I feel most alive today?",
        "What worry occupied my mind today?",
        "What made me smile or laugh today?",
        "What step did I take toward my goals today?",
        "What distraction did I overcome today?",
        "What would make tomorrow even better than today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}