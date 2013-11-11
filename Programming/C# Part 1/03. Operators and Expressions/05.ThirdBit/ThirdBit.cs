// 04. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer
// is 1 or 0.

using System;

class ThirdBit
{
    static void Main()
    {
        int number;
        
        Console.Write("Enter an integer number: ");

        bool result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input

        if (result)
        {
            int position = 3;
            int mask = 1 << position;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> position;

            Console.WriteLine("Third bit is {0}", bit);
        }
        else
        {
            Console.WriteLine("Wrong number!");
        }
    }
}
