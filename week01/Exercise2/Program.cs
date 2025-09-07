using System;
using System.Reflection.PortableExecutable;
// Convert string -> int : int.Parse()
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Please, enter you grade ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string letter = "";
        string gradeSign = " ";

        if (percent >= 90 && percent <= 100)
        {
            letter = "A";
        }
        else if (percent >= 80 && percent < 90)
        {
            letter = "B";
        }
        else if (percent >= 70 && percent < 80)
        {
            letter = "C";
        }
        else if (percent >= 60 && percent < 70)
        {
            letter = "D";
        }
        else if (percent >= 0 && percent < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Error! Please enter a valid grade between 0 and 100");
            return;
        }

        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            gradeSign = "+";
            if (letter =="A")
            {
                gradeSign = "";
            }
        }
        else if (lastDigit <3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }
        if (letter == "F")
        {
            gradeSign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{gradeSign}");
        if (percent >= 70)
        {
            Console.WriteLine("Great! You are incredible, kepp going!");
        }
        else
        {
            Console.WriteLine("Oh! Better luck next time!");
        }

    }
}