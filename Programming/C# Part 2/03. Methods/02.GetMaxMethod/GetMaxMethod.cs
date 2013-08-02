using System;

class GetMaxMethod
{
    static int GetMax(int firstInt, int secondInt)
    {
        int max = firstInt;
        if (secondInt > max)
        {
            max = secondInt;
        }
        return max;
    }

    static void Main()
    {
        Console.Write("Enter first integer, please: ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer, please: ");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer, please: ");
        int thirdInt = int.Parse(Console.ReadLine());

        int max = GetMax(firstInt, secondInt);
        max = GetMax(max, thirdInt);
        Console.WriteLine("The biggest of the three integer is: {0}", max);
    }
}
