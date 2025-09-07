using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int numberUser = 0;
        int count = 0;
        do
        {
            Console.WriteLine(magicNumber);
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            numberUser = int.Parse(answer);
            count++;
            if (magicNumber > numberUser)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < numberUser)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }


        } while (magicNumber != numberUser);
        Console.WriteLine($"You have {count} guesses.");
    }
}