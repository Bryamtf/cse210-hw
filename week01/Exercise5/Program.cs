using System;
/*
returnType FunctionName(dataType parameter1, dataType parameter2)
{
    // function_body
}
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(squareNumber, name);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(int number, string name)
    {
        Console.WriteLine($"{name}, the square of your name is {number}");
    }


}