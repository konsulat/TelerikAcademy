using System;

class BinarySearch
{
    static void Main()
    {
        // Binary search works only on sorted arrays
        int[] array = { 2, 6, 15, 30, 45, 90, 115, 156, 245, 345, 456, 1089, 1234 };
        int givenElement = 6;

        int searchedIndex = -1;
        int start = 0;
        int end = array.Length - 1;

        while (end >= start)
        {
            int middle = (start + end) / 2;

            if (array[middle] < givenElement)
            {
                start = middle + 1;
            }
            else if (array[middle] > givenElement)
            {
                end = middle - 1;
            }
            else
            {
                searchedIndex = middle;
                break;
            }
        }

        if (searchedIndex == -1)
        {
            Console.WriteLine("No such element");
        }
        else
        {
            Console.WriteLine("The given element {0} has index {1}", givenElement, searchedIndex);
        }
    }
}
