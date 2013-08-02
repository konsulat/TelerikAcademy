using System;

class MaximalSumSequence
{
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        // using Kadane algorithm
        int currentSum = array[0];
        int currentIndex = 0;
        int maxSum = array[0];
        int maxStartIndex = 0;
        int maxEndIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum > 0)
            {
                currentSum += array[i];
            }
            else
            {
                currentSum = array[i];
                currentIndex = i;
            }

            if (currentSum > maxSum)
            {
                maxStartIndex = currentIndex;
                maxEndIndex = i;
                maxSum = currentSum;
            }
        }

        Console.WriteLine("The sequence of maximal sum is");
        Console.Write("{ ");
        for (int i = maxStartIndex; i <= maxEndIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("}");
        Console.WriteLine("The maximal sum is {0}", maxSum);
    }
}
