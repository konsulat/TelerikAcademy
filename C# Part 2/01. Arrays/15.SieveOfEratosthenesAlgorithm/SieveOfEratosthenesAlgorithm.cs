using System;

class SieveOfEratosthenesAlgorithm
{
    static void Main()
    {
        bool[] array = new bool[10000000];

        for (int i = 2; i < array.Length; i++)
        {
            array[i] = true;
        }

        int maxLenght = (int)Math.Sqrt(array.Length);

        for (int i = 2; i < maxLenght; i++)
        {
            if (array[i])
            {
                for (int j = i * i; j < array.Length; j += i)
                {
                    array[j] = false;
                }
            }
        }

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
