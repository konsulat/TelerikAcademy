using System;

class MergeSortAlgorithm
{
    static void DoMerge(int[] numbers, int left, int middle, int right)
    {
        int[] temp = new int[numbers.Length];
        int leftEnd = middle - 1;
        int tempPosition = left;
        int numberOfElements = right - left + 1;

        while (left <= leftEnd && middle <= right)
        {
            if (numbers[left] <= numbers[middle])
            {
                temp[tempPosition++] = numbers[left++];
            }
            else
            {
                temp[tempPosition++] = numbers[middle++];
            }
        }

        while (left <= leftEnd)
        {
            temp[tempPosition++] = numbers[left++];
        }

        while (middle <= right)
        {
            temp[tempPosition++] = numbers[middle++];
        }

        for (int i = 0; i < numberOfElements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }

    }

    static void MergeSort(int[] numbers, int left, int right)
    {
        if (right > left)
        {
            int middle = (left + right) / 2;

            MergeSort(numbers, left, middle);
            MergeSort(numbers, middle + 1, right);

            DoMerge(numbers, left, middle + 1, right);
        }
        
    }

    static void Main()
    {
        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

        MergeSort(numbers, 0, numbers.Length - 1);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
