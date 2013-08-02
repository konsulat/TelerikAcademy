using System;

class MinMaxAvrgSumProductForNumbers
{
    static T Min<T>(params T[] sequence)
    {
        dynamic min = sequence[0];
        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] < min)
            {
                min = sequence[i];
            }
        }

        return min;
    }

    static T Max<T>(params T[] sequence)
    {
        dynamic max = sequence[0];
        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] > max)
            {
                max = sequence[i];
            }
        }

        return max;
    }

    static T Average<T>(params T[] sequence)
    {
        dynamic average;
        dynamic sum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        average = (dynamic)sum / sequence.Length;

        return average;
    }

    static T Sum<T>(params T[] sequence)
    {
        dynamic sum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum;
    }

    static T Product<T>(params T[] sequence)
    {
        dynamic product = 1;

        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }

        return product;
    }

    static void Main()
    {
        Console.WriteLine("The minimum of sequence 5, 3, 7, -1, 0 is: {0}", Min(5, 3, 7, -1, 0));
        Console.WriteLine("The minimum of sequence 5.4, 3.6, 7, -1.5, 0.3 is: {0}", Min(5.4, 3.6, 7, -1.5, 0.3));
        Console.WriteLine("The maximum of sequence 4.6F, 6.7F, -6.5F is: {0}", Max(4.6F, 6.7F, -6.5F));
        Console.WriteLine("The maximum of sequence 45.78M, 67.987M, -19M, 6.6M is: {0}", Max(45.78M, 67.987M, -19M, 6.6M));
        Console.WriteLine("The average of sequence 4, 6, -7, 5, 5 is: {0}", Average(4, 6, -7, 5, 5));
        Console.WriteLine("The average of sequence 67L, 56L, 3L is: {0}", Average(67L, 56L, 3L));
        Console.WriteLine("The sum of sequence 5, -9, 0, 5, 6 is: {0}", Sum(5, -9, 0, 5, 6));
        Console.WriteLine("The sum of sequence 5.678, -45.32, 0.25, 6.7, 6.4 is: {0}", Sum(5.678, -45.32, 0.25, 6.7, 6.4));
        Console.WriteLine("The product of sequence 5.6F, -6.5F, 4.4F, 3.4F, 7.5F is: {0}", Product(5.6F, -6.5F, 4.4F, 3.4F, 7.5F));
        Console.WriteLine("The product of sequence 5, -6, 4, 3, 7 is: {0}", Product(5, -6, 4, 3, 7));
    }
}
