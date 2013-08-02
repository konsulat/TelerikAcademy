using System;

class SelectionSortAlgorithm
{
    static void Main()
    {
        int[] array = { 3, 2, 1, 4, 2, 5, 3, 4, 0 };

        Console.WriteLine("Array before sorting");
        Console.Write("{ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("}");

        int temp;
        int minIndex;

        for (int i = 0; i < array.Length - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }

        Console.WriteLine("Array after sorting");
        Console.Write("{ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("}");
    }
}
