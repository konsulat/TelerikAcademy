// 09. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// Cn = 1 / (n + 1) (2n : n) = 2n! / (n + 1)!n! for n >= 0.
// 10. Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n;

        Console.Write("Type a positive integer (N >= 0): ");

        bool isInt = int.TryParse(Console.ReadLine(), out n);

        if (!isInt || n < 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine("The 0th Catalan number is 1");
        }
        else
        {
            BigInteger nominator = 1;
            BigInteger nPlusOneFactorial = 1;
            BigInteger nFactorial = 1;
            BigInteger catalanNumber = 1;

            for (int i = 2 * n; i > 0; i--)
            {
                nominator *= i;
            }

            for (int i = 1; i <= n; i++)
			{
			    nPlusOneFactorial *= (i + 1);
                nFactorial *= i;
			}

            catalanNumber = nominator / (nPlusOneFactorial * nFactorial);

            Console.WriteLine("The {0}th Catalan number is {1}", n, catalanNumber);
        }
    }
}
