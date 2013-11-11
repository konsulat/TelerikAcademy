// 07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
// E.g. 37 is prime.

using System;

class PrimeNumber
{
    static void Main()
    {
        uint number;

        Console.Write("Enter a positive integer (from 0 to 100): ");

        bool result = uint.TryParse(Console.ReadLine(), out number); // Checks for valid input

        if (!result || number > 100)
        {
            Console.WriteLine("Wrong positive integer or out of range!");
            return; // Exits if not valid uint number or out of range
        }

        if (number == 0 || number == 1)
        {
            Console.WriteLine("The number {0} isn't prime", number);
        }
        else if (number == 2 || number == 3 || number == 5 || number == 7)
        {
            Console.WriteLine("The number {0} is prime", number);
        }
        else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
        {
            Console.WriteLine("The number {0} isn't prime", number);
        }
        else
        {
            Console.WriteLine("The number {0} is prime", number);
        }
    }
}
