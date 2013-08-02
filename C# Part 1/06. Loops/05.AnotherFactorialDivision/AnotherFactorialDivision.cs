using System;
using System.Numerics;

class AnotherFactorialDivision
{
    static void Main()
    {
        int n;
        Console.Write("Type a positive integer (N) bigger than 1: ");
        bool isInt = int.TryParse(Console.ReadLine(), out n);
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
        for (int i = 0; i < n; i++)
        {
            nFactorial *= (i + 1);
            resulFactorial *= (k - i);
        }
        Console.WriteLine("{0}!*{1}!/({1}-{0})! = {2}", n, k, nFactorial*resulFactorial);
    }
}
