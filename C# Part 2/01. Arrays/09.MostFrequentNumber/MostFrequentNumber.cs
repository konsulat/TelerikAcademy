using System;

class MostFrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int currentNum = array[0];
        int maxNum = array[0];
        int currentAppearance = 1;
        int maxAppearance = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == int.MinValue)
            {
                continue;
            }
            else
            {
                currentNum = array[i];
                currentAppearance = 0;
            }

            for (int j = i; j < array.Length; j++)
            {
                if (array[j] == currentNum)
                {
                    currentAppearance++;
                    array[j] = int.MinValue;
                }
            }

            if (currentAppearance > maxAppearance)
            {
                maxAppearance = currentAppearance;
                maxNum = currentNum;
            }
        }

        Console.WriteLine("The most frequent number is {0} ({1} times)", maxNum, maxAppearance);
    }
}