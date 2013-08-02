using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        int n;
        Console.Write("Type a positive integer (N) bigger than 2: ");
        bool isInt = int.TryParse(Console.ReadLine(), out n);
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
