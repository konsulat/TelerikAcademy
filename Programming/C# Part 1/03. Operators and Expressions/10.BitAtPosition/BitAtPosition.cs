// 10. Write a boolean expression that returns if the bit at position p (counting from 0)
// in a given integer number v has value of 1. Example: v=5; p=1 → false.

using System;

class BitAtPosition
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

        Console.WriteLine("Integer v = {0}. The bit in position p = {0} has value of 1? -> {2}",
            number, position, bit == 1);
    }
}
