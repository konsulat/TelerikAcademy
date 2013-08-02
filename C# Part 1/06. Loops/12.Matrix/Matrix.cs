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
