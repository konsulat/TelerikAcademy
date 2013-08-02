using System;

class SwapTwoIntegers
{
    static void Main()
    {
        int firstInt = 5;
        int secondInt = 10;
        int tempInt;
        Console.WriteLine("Integers before exchanging values are {0} and {1}", firstInt, secondInt);
        tempInt = firstInt;
        firstInt = secondInt;
        secondInt = tempInt;
        Console.WriteLine("Integers after exchanging values are {0} and {1}", firstInt, secondInt);
    }
}
