// 09. Write a program to print the first 100 members of the sequence of Fibonacci:
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class FibonacciFirts100Members
{
    static void Main()
    {
        // Fibonacci numbers should be BigInteger because they overflow all primitive integer types
        BigInteger firstNum = 0;
        BigInteger secondNum = 1;

        Console.WriteLine("First 100 Fibonacci members");

        BigInteger sum = 0;

        for (int i = 0; i < 100; i++)
        {
            Console.Write(firstNum);

            if (i != 99)
            {
                Console.Write(", ");
            }

            sum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = sum;
        }

        Console.WriteLine();
    }
}
