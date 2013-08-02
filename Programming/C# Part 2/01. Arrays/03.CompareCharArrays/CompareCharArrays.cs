using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstArray = { 'F', 'i', 'r', 's', 't', ' ', 'a', 'r', 'r', 'a', 'y' };
        char[] secondArray = { 'S', 'e', 'c', 'o', 'n', 'd', ' ', 'a', 'r', 'r', 'a', 'y' };
        int minLenght = Math.Min(firstArray.Length, secondArray.Length);
        int smallerArray = 0;

        for (int index = 0; index < minLenght; index++)
        {
            if (firstArray[index] < secondArray[index])
            {
                smallerArray = 1;
                break;
            }
            else if (firstArray[index] > secondArray[index])
            {
                smallerArray = 2;
                break;
            }
        }

        if (smallerArray == 1)
        {
            Console.WriteLine("The first array is earlier lexicographically.");
        }
        else if (smallerArray == 2)
        {
            Console.WriteLine("The second array is earlier lexicographically.");
        }
        else
        {
            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("The first array is earlier lexicographically.");
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("The second array is earlier lexicographically.");
            }
            else
            {
                Console.WriteLine("Two arrays are equal lexicographically.");
            }
        }
    }
}
