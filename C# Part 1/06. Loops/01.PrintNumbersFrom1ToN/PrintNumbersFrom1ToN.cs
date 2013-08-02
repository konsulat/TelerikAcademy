using System;

class PrintNumbersFrom1ToN
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
                Console.WriteLine(i);
            }
        }
    }
}
