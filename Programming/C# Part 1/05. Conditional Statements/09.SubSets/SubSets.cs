// 09. We are given 5 integer numbers. Write a program that checks if the sum of some subset of
// them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class SubSets
{
    static void Main()
    {
        int[] numbers = new int[5];
        bool isInt = false;

        Console.WriteLine("Enter 5 integers (each one on different row)");

        for (int i = 0; i < numbers.Length; i++)
        {
            isInt = int.TryParse(Console.ReadLine(), out numbers[i]);

            if (!isInt)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }

        int count = 0;
        int maxSubsets = (int)Math.Pow(2, 5) - 1;

        for (int i = 1; i < maxSubsets; i++)
        {
            long currentSum = 0;

            for (int j = 0; j < 5; j++)
            {
                int mask = 1 << j;
                int numberAndMak = i & mask;
                int bit = numberAndMak >> j;
                if (bit == 1)
                {
                    currentSum += numbers[j];
                }
            }

            if (currentSum == 0)
            {
                count++;
            }
        }

        if (count == 1)
        {
            Console.WriteLine("Subset, the sum of which is zero, is {0}", count);
        }
        else
        {
            Console.WriteLine("Subsets, the sum of them is zero, are {0}", count);
        }
    }
}
