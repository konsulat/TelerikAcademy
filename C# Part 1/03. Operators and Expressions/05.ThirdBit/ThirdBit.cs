using System;

class ThirdBit
{
    static void Main()
    {
        int number;
        bool result;
        Console.Write("Enter an integer number: ");
        result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input
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
