using System;

class OddOrEvenInt
{
    static void Main()
    {
        int number;
        bool result;
        Console.Write("Enter an integer number: ");
        result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input
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
