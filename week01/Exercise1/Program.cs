using System;

// Console.ReadLine -> input the user
// $-> format string
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        /*Console.WriteLine("Hello World! This is the Exercise1 Project.");
        int x = 5;
        Console.WriteLine(x);

        Console.Write("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine(color.Trim());

        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}");*/
    }
}