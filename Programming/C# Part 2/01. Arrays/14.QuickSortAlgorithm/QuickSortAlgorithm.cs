using System;

class QuickSortAlgorithm
{
    static void QuickSort(string[] elements, int left, int right)
    {
        int i = left;
        int j = right;
        string middle = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(middle) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(middle) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                string temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            QuickSort(elements, left, j);
        }

        if (i < right)
        {
            QuickSort(elements, i, right);
        }
    }

    static void Main()
    {
        string[] array = { "s", "a", "m", "p", "l", "e" };

        QuickSort(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
