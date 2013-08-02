using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i < 11; i++)
        {
            int bitToTake = i;
            int mask = 1 << bitToTake;
            int numberAndMask = input & mask;
            int bit = numberAndMask >> bitToTake;

            if (numberAndMask == 0)
            {
                Console.WriteLine("A" + (10 - i));
            }
        }
    }
}