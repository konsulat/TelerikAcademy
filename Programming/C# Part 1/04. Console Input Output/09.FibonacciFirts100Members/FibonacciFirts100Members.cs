using System;
using System.Numerics;

class FibonacciFirts100Members
{
    static void Main()
    {
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
