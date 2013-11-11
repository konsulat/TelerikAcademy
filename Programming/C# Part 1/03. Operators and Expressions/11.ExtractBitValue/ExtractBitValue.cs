// 11. Write an expression that extracts from a given integer i the value of a given bit number b.
// Example: i=5; b=2 → value=1.

using System;

class Program
{
    static void Main()
    {
        int number;
        byte position;
        bool result = false;

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

        Console.WriteLine("Integer i = {0}. The value of bit b = {1} is v = {2}",
            number, position, bit);
    }
}
