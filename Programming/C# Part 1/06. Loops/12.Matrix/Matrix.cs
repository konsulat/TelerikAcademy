// 12. Write a program that reads from the console a positive integer number N (N < 20) and outputs
// a matrix like the following:
//  N = 3			N = 4
//  1 2 3           1 2 3 4
//  2 3 4           2 3 4 5
//  4 5 6           3 4 5 6
//                  4 5 6 7

using System;

class Matrix
{
    static void Main()
    {
        int n;

        Console.Write("Type a positive integer (0 < N < 20): ");

        bool isInt = int.TryParse(Console.ReadLine(), out n);

        if (!isInt || n <= 0 || n >= 20)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.WriteLine("Output matrix:");

        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col <= n + row - 1; col++)
            {
                Console.Write("{0, -3}", col);
            }
            Console.WriteLine();
        }
    }
}
