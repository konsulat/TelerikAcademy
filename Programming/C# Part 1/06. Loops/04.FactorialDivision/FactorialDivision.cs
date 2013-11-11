// 04. Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        int n;
        bool isInt = false;

        Console.Write("Type a positive integer (N) bigger than 2: ");

        isInt = int.TryParse(Console.ReadLine(), out n);

        if (!isInt || n <= 2)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int k;

        Console.Write("Type another integer (K) between 1 and {0}: ", n);

        isInt = int.TryParse(Console.ReadLine(), out k);

        if (!isInt || k <= 1 || k >= n)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        BigInteger resultFactorial = 1;

        for (int i = n; i > k; i--)
        {
            resultFactorial *= i;
        }

        Console.WriteLine("{0}!/{1}! = {2}", n, k, resultFactorial);
    }
}
