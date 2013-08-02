using System;

class Spiral
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] arraySpiral = new int[N, N];

        string direction = "right";

        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= N * N; i++)
        {
            if (direction == "right" && (currentCol >= N || arraySpiral[currentRow,currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= N || arraySpiral[currentRow,currentCol] != 0))
            {
                currentRow--;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || arraySpiral[currentRow,currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || arraySpiral[currentRow,currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "right";
            }

            arraySpiral[currentRow, currentCol] = i;

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

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0}{1}", arraySpiral[i, j], "  ");
            }
            Console.WriteLine();
        }

    }
}
