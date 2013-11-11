// 07. Write a program that reads a number N and calculates the sum of the first N members of
// the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;
using System.Numerics;

class FibonacciSum
{
    static void Main()
    {
        int n;

        Console.Write("Type a positive integer (N): ");

        bool isInt = int.TryParse(Console.ReadLine(), out n);

        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        BigInteger sum = 0;
        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger result = 0;

        if (n == 1)
        {
            Console.WriteLine("The first member of Fibonacci sequence is {0}", firstNum);
        }
        else
        {
            for (int i = 1; i < n; i++)
            {
                result = firstNum + secondNum;
                sum += secondNum;
                firstNum = secondNum;
                secondNum = result;
            }

            Console.WriteLine("The sum of the first {0} members of Fibonacci sequence is {1}", n, sum);
        }
    }
}
