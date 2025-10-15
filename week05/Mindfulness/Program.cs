using System;
/*
EXCEEDING REQUIREMENTS:
1. Implemented non-repeating questions in ReflectingActivity
2. Added input validation in menu
3. Enhanced user experience with proper console clearing and formatting
*/
class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello World! This is the Mindfulness Project.");
       
        while (true)
        {
            Console.Clear();
            DisplayMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartBreathingActivity();
                    break;
                case "2":
                    StartReflectingActivity();
                    break; 
                case "3":
                    StartListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose 1-4.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void StartBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.Run();

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    static void StartReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.Run();

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    static void StartListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Run();

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}