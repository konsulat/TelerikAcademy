using System;
using System.Collections.Generic;

class SubsetSumsB
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());

        long[] numbers = new long[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        List<long> sums = new List<long>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0, len = sums.Count; j < len; j++)
            {
                sums.Add(sums[j] + numbers[i]);
            }
            sums.Add(numbers[i]);
        }

        int sumCounter = 0;
        for (int i = 0; i < sums.Count; i++)
        {
            if (sums[i] == s)
            {
                sumCounter++;
            }
        }

        Console.WriteLine(sumCounter);
    }
}
