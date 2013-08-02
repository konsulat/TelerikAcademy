using System;

class MinMaxAvrgSumProductForInts
{
    static int Min(params int[] sequence)
    {
        int min = sequence[0];
        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] < min)
            {
                min = sequence[i];
            }
        }

        return min;
    }

    static int Max(params int[] sequence)
    {
        int max = sequence[0];
        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] > max)
            {
                max = sequence[i];
            }
        }

        return max;
    }

    static decimal Average(params int[] sequence)
    {
        decimal average;
        int sum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        average = (decimal)sum / sequence.Length;

        return average;
    }

    static long Sum(params int[] sequence)
    {
        long sum = 0L;

        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum;
    }

    static long Product(params int[] sequence)
    {
        long product = 1L;

        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }

        return product;
    }

    static void Main()
    {
        Console.WriteLine("The minimum of sequence 5, 3, 7, -1, 0 is: {0}", Min(5, 3, 7, -1, 0));
        Console.WriteLine("The maximum of sequence 45, 67, -19, 6 is: {0}", Max(45, 67, -19, 6));
        Console.WriteLine("The average of sequence 4, 6, -7, 5, 8 is: {0:0.00}", Average(4, 6, -7, 5, 8));
        Console.WriteLine("The sum of sequence 5, -9, 0, 5, 6 is: {0}", Sum(5, -9, 0, 5, 6));
        Console.WriteLine("The product of sequence 5, -6, 4, 3, 7, 2, -8, -9 is: {0}", Product(5, -6, 4, 3, 7, 2, -8, -9));
    }
}
