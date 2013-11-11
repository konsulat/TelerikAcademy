// 02. Write a program that prints all the numbers from 1 to N, that are not divisible by
// 3 and 7 at the same time.

using System;

class NNumbersNotDevidedBy3And7
{
    static void Main()
    {
        int n;

        Console.Write("Type a positive integer: ");

        bool isInt = int.TryParse(Console.ReadLine(), out n);

        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 21 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
