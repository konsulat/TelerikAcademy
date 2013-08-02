using System;

class ArrayIndexMultipliedBy5
{
    static void Main()
    {
        int[] array = new int[20];
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = index * 5;
            Console.WriteLine("array[{0}] = {1}", index, array[index]);
        }
    }
}
