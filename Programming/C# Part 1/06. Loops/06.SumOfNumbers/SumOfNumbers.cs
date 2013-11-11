// 06. Write a program that, for a given two integer numbers N and X, calculates the sum
// S = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;

class SumOfNumbers
{
    static void Main()
    {
        int n;
        bool isInt = false;

        Console.Write("Type a positive integer (N): ");

        isInt = int.TryParse(Console.ReadLine(), out n);

        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int x;

        Console.Write("Type another positive integer (X): ");

        isInt = int.TryParse(Console.ReadLine(), out x);

        if (!isInt || x <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        decimal sum = 1M;
        decimal factorial = 1M;
        decimal power = 0M;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power = (decimal)Math.Pow(x, i);
            sum += factorial / power;
        }

        if (n == 1)
        {
            Console.WriteLine("The sum S = 1 + 1!/{0} = {1}", x, sum);
        }
        else if (n == 2)
        {
            Console.WriteLine("The sum S = 1 + 1!/{0} + 2!/{0}^2 = {2}", x, n, sum);
        }
        else
        {
            Console.WriteLine("The sum S = 1 + 1!/{0} + 2!/{0}^2 + ... + {1}!/{0}^{1} = {2}", x, n, sum);
        }
    }
}
