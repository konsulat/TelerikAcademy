using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        int startIndex = 0;
        int sequence = 1;
        int bestStartIndex = 0;
        int maxSequence = 1;

        for (int index = 1; index < array.Length; index++)
        {
            if (array[index] > array[index - 1])
            {
                sequence++;
            }
            else
            {
                startIndex = index;
                sequence = 1;
            }

            if (sequence > maxSequence)
            {
                maxSequence = sequence;
                bestStartIndex = startIndex;
            }
        }

        int maxIndex = bestStartIndex + maxSequence;
        Console.WriteLine("Maximal sequence - {0}", maxSequence);
        Console.Write("{ ");
        for (int index = bestStartIndex; index < maxIndex; index++)
        {
            Console.Write(array[index]);
            if (index != maxIndex - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" }");
    }
}
