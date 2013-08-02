using System;

class GivenSumSequence
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int givenSum = 11;

        int startIndex = 0;
        int endIndex = 0;
        int currentSum = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (currentSum == givenSum)
            {
                startIndex = i - 1;
                break;
            }
            else
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum == givenSum)
                    {
                        endIndex = j;
                        break;
                    }
                    else if (currentSum > givenSum)
                    {
                        currentSum = array[i + 1];
                        break;
                    }
                }
            }
        }

        if (startIndex == -1)
        {
            Console.WriteLine("{{ {0} }}", array[0]);
        }
        else if (startIndex == 0 && endIndex == 0)
        {
            Console.WriteLine("No such sum in array");
        }
        else
        {
            Console.Write("{ ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("}");
        }
    }
}
