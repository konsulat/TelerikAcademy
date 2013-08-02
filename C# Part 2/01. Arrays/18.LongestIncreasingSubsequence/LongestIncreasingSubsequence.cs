using System;
using System.Collections.Generic;

class LongestIncreasingSubsequence
{
    static bool IsSorted(List<int> currentList)
    {
        for (int i = 0; i < currentList.Count - 1; i++)
        {
            if (currentList[i + 1] >= currentList[i])
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        int[] numbers = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };

        List<int> currentList = new List<int>();
        List<int> maxList = new List<int>();

        int maxI = (int)Math.Pow(2, numbers.Length) - 1;
        for (int i = 1; i <= maxI; i++)
        {
            List<int> sublist = new List<int>();
            for (int j = 0; j < numbers.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentList.Add(numbers[j]);
                }
            }

            if (IsSorted(currentList))
            {
                if (currentList.Count > maxList.Count)
                {
                    maxList.Clear();
                    for (int j = 0; j < currentList.Count; j++)
                    {
                        maxList.Add(currentList[j]);
                    }
                }
                currentList.Clear();
            }
            else
            {
                currentList.Clear();
            }
        }

        Console.Write("{");
        Console.Write(string.Join(", ", maxList));
        Console.WriteLine("}");
    }
}
