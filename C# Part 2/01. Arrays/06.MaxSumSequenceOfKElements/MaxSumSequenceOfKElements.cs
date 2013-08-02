using System;

class MaxSumSequenceOfKElements
{
    static void Main()
    {
        Console.Write("Input integer N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input integer K (K <= N): ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        int maxSum = 0;
        string currentSequence = "";
        string maxSequence = "";

        for (int i = 0; i < array.Length; i++)
        {
            if (i + k > array.Length)
            {
                break;
            }

            for (int j = i; j < k + i; j++)
            {
                currentSum += array[j];
                currentSequence += array[j] + " ";
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxSequence = currentSequence;
            }
            currentSum = 0;
            currentSequence = "";
        }
        Console.WriteLine("The maximal sum of {0} sequence elements is {{ {1}}} = {2}",
            k, maxSequence, maxSum);

    }
}
