using System;

class MaximalElementInAPortionOfArray
{
    static int FindMaxInPortion(int[] numbers, int startIndex, int length)
    {
        int max = int.MinValue;
        int maxIndex = 0;
        for (int i = startIndex; i < startIndex + length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                maxIndex = i;
            }
        }

        int tempValue = numbers[maxIndex];
        numbers[maxIndex] = numbers[startIndex];
        numbers[startIndex] = tempValue;

        return max;
    }

    static int[] SortDescending(int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            max = FindMaxInPortion(numbers, i, numbers.Length - i);
            numbers[i] = max;
        }

        return numbers;
    }

    static void PrintArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 1, 6, 8, 17, 6, 5, 9, 15, 9, 3, 10, 8, 7 };
        int startIndex = 2;
        int length = 6;
        Console.WriteLine("Maximal element in a portion: {0}", FindMaxInPortion(numbers, startIndex, length));
        Console.WriteLine("Sorted in descending order:");
        SortDescending(numbers);
        PrintArray(numbers);
        Console.WriteLine("Sorted in ascending order:");
        Array.Reverse(numbers);
        PrintArray(numbers);
    }
}
