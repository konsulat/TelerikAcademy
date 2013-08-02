using System;
using System.Numerics;

class Factorial
{
    static BigInteger CalculateFactorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = n; i >= 1; i--)
        {
            factorial *= i;
        }
        return factorial;
    }
    static void Main()
    {
        Console.Write("Enter an integer n [1..100]: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("n!: {0}" , CalculateFactorial(number));
    }
}
