using System;

class CheckNeighborsInArray
{
    static int IsBigger(int[] numbers)
    {
        if (numbers.Length == 1)
        {
            return 0;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }
            else if (i == numbers.Length - 1)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    return i;
                }
            }
            else
            {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    return i;
                }
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] numbers = { 5, 7, 4, 5, 3, 6, 10, 5 };

        Console.WriteLine("Index of the first element in array bigger than its neighbor/s: {0}", IsBigger(numbers));
    }
}
