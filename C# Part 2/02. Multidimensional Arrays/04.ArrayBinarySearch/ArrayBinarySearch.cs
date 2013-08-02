using System;

class ArrayBinarySearch
{
    static void Main()
    {
        Console.Write("Input an integer N (N > 0): ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Input an integer K: ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);

        if (array[0] > k)
        {
            Console.WriteLine("No number in array smaller then K ({0})", k);
        }
        else
        {
            int index = Array.BinarySearch(array, k);
            if (index >= 0)
            {
                Console.WriteLine("Largest number in array <= K ({0}): {1}", k, array[index]);
            }
            else
            {
                Console.WriteLine("Largest number in array <= K ({0}): {1}", k, array[~index - 1]);
            }
        }
    }
}
