using System;

class CompareIntArrays
{
    static void Main()
    {
        Console.WriteLine("Compair two integer arrays");
        Console.Write("Enter first array length: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter second array length: ");
        int m = int.Parse(Console.ReadLine());

        int[] firstIntArray = new int[n];
        int[] secondIntArray = new int[m];

        bool areEqual = true;
        if (n == m)
        {
            Console.WriteLine("Type elements of the first array");
            for (int index = 0; index < firstIntArray.Length; index++)
            {
                Console.Write("First array[{0}] = ", index);
                firstIntArray[index] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < secondIntArray.Length; index++)
            {
                Console.Write("Second array[{0}] = ", index);
                secondIntArray[index] = int.Parse(Console.ReadLine());
            }


            for (int index = 0; index < n; index++)
            {
                if (firstIntArray[index] != secondIntArray[index])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        else
        {
            areEqual = false;
        }
        
        Console.WriteLine("Are two arrays equal? --> {0}", areEqual);
    }
}
