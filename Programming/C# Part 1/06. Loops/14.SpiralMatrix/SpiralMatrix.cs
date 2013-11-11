// 14.* Write a program that reads a positive integer number N (N < 20) from console and outputs
// in the console the numbers 1 ... N numbers arranged as a spiral.
//	Example for N = 4
//    1  2  3  4
//    12 13 14 5
//    11 16 15 6
//    10 9  8  7

using System;

class SpiralMatrix
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

        int[,] spiralMatrix = new int[n, n]; // two dimensional array with n x n size

        string direction = "right";

        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (currentCol >= n || spiralMatrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= n || spiralMatrix[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || spiralMatrix[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || spiralMatrix[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "right";
            }

            spiralMatrix[currentRow, currentCol] = i;

            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }

        Console.WriteLine("Spiral matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, -4}", spiralMatrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
