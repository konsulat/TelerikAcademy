// 01. Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenInt
{
    static void Main()
    {
        int number;

        Console.Write("Enter an integer number: ");

        bool result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input

        if (result)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
        }
        else
        {
            Console.WriteLine("Wrong number!");
        }
    }
}
