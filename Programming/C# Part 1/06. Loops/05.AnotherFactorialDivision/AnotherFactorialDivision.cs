// 05. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class AnotherFactorialDivision
{
    static void Main()
    {
        int n;
        bool isInt = false;

        Console.Write("Type a positive integer (N) bigger than 1: ");

        isInt = int.TryParse(Console.ReadLine(), out n);

        if (!isInt || n <= 1)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int k;

        Console.Write("Type another integer (K) bigger than {0}: ", n);

        isInt = int.TryParse(Console.ReadLine(), out k);

        if (!isInt || k <= n)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        //N!*K!/(K-N)! = N!*(K*(K-1)*(K-2)*...*(K-N+1))

        BigInteger nFactorial = 1;
        BigInteger resulFactorial = 1;

        for (int i = n; i >= 1; i--)
        {
            nFactorial *= i;
        }

        for (int i = k; i >= k - n + 1; i--)
        {
            resulFactorial *= i;
        }

        Console.WriteLine("{0}!*{1}!/({1}-{0})! = {2}", n, k, nFactorial*resulFactorial);
    }
}
