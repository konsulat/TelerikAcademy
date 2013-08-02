using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Input number n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int col = 0; col < matrix.GetLongLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = (row + 1) + (n * col);
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
