using System;
// Count -> property get the size
// Iterating -> foreach(), for(int =0; i<list.Count; i++)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int number = 0;
        int sum = 0;
        Console.WriteLine("Enter a list of number, type 0 when finished");

        do
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            if (number != 0)
            {
                numbers.Add(number);
            }


        } while (number != 0);
        foreach (int num in numbers)
        {
            sum += num;
        }
        ;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()} ");
        int tempo = 0;
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                if (tempo == 0)
                {
                    tempo = num;
                }
                else if (num < tempo)
                {
                    tempo = num;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {tempo} ");

        numbers.Reverse();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        //Console.WriteLine($"The sorted list is: {} ");


    }

}