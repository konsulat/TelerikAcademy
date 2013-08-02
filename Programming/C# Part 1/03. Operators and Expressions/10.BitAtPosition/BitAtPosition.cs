using System;

class BitAtPosition
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
        Console.Write("Enter position: ");
        result = byte.TryParse(Console.ReadLine(), out position); // Checks for valid input
        if (!result || position >= 32)
        {
            Console.WriteLine("Wrong position!");
            return; // Exits if not valid position
        }
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;

        if (bit == 1)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
