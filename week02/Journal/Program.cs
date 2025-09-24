using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._prompText = prompt.GetRandomPrompt();
                    Console.WriteLine($"{entry._prompText}");
                    Console.Write("> ");
                    entry._entryText = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":

                    Console.WriteLine("Enter filename");
                    string loadFile = Console.ReadLine();
                    try
                    {
                        journal.LoadFromFile(loadFile);
                        Console.WriteLine("Journal loaded successfully!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error loading file:{e.Message}");
                    }
                    break;
                case "4":
                    Console.WriteLine("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    if (File.Exists(saveFile))
                    {
                        Console.WriteLine("File already exists. OverWrite? (y/n)");
                        if (Console.ReadLine().ToLower() != "y")
                        {
                            break;
                        }
                    }
                    try
                    {
                        journal.SaveToFile(saveFile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro saving file: {e.Message}");

                    }
                    break;
                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choise. Try again");
                    break;
            }

        }

    }
}