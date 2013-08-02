using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Input number n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int value = 1;
        int maxCol = n;

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < maxCol; col++)
            {
                matrix[row, col] = value;
                value += (n - row) + (col + 1);
            }
            value = matrix[row, 0] + (n - row);
            maxCol--;
        }
        
        int minCol = 1;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            value = matrix[row, minCol - 1] + n;
            for (int col = minCol; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = value;
                value += n + row - col;
            }
            minCol++;
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
