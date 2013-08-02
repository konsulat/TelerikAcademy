using System;

class IntDevidedBy7And5
{
    static void Main()
    {
        int number;
        bool result;
        Console.Write("Enter an integer number: ");
        result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input
        if (result)
        {
            if (number % 7 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Your number can be devided by 7 and 5 in the same time");
            }
            else
            {
                Console.WriteLine("Your number cannot be devided by 7 and 5 in the same time");
            }
        }
        else
        {
            Console.WriteLine("Wrong number!");
        }
    }
}
