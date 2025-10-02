using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        /*
        Reference reference = new Reference("3 Nephi", 5, 13);
        string scriptureText = "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life.";

        Scripture scripture = new Scripture(reference, scriptureText);
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            scripture.HideRandomWords(3);

        }
        Console.WriteLine("Program ended. Gob Job memorizing!");
        */
        ScriptureLibrary library = new ScriptureLibrary("scriptures.txt");
        if (library.GetScriptureCount() == 0)
        {
            Console.WriteLine("No scriptures found. Using default scripture.");
            Reference reference = new Reference("John", 3, 16);
            string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
            RunScriptureMemorizer(new Scripture(reference, scriptureText));
        }
        else
        {
            Scripture randomScripture = library.GetRandomScripture();
            RunScriptureMemorizer(randomScripture);
        }
    }
    static void RunScriptureMemorizer(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine("===============================\n");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden! Great job memorizing!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                break;
            }
            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nThank you for using Scripture Memorizer!");
    }
}