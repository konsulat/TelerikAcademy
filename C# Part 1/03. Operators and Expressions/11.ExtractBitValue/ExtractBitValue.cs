using System;

class Program
{
    static void Main()
    {
        int number;
        byte position;
        bool result;
        Console.Write("Enter an integer number: ");
        result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input
        if (!result)
        {
            Console.WriteLine("Wrong integer!");
            return; // Exits if not valid integer
        }
        Console.Write("Enter bit number: ");
        result = byte.TryParse(Console.ReadLine(), out position); // Checks for valid input
        if (!result || position >= 32)
        {
            Console.WriteLine("Wrong bit number!");
            return; // Exits if not valid bit number
        }
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;

        Console.WriteLine("The value of bit {0} is {1}", position, bit);
    }
}
