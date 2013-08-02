using System;

class LargestAreaOfEqualNeighborElements
{
    static int[,] matrix = {{1, 3, 2, 2, 2, 4},
                            {3, 3, 3, 2, 4, 4},
                            {4, 3, 1, 2, 3, 3},
                            {4, 3, 1, 3, 3, 1},
                            {4, 3, 3, 3, 1, 1}};
    static int area = 0;
    static int bestArea = 0;
    static int number = new int();
    static int bestNumber = new int();

    static void DepthFirstSearch(int row, int col)
    {
        if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
        {
            return;
        }

        if (matrix[row, col] != number)
        {
            return;
        }

        area++;
        if (area > bestArea)
        {
            bestArea = area;
            bestNumber = number;
        }

        matrix[row, col] = 0;
        DepthFirstSearch(row, col + 1);
        DepthFirstSearch(row + 1, col);
        DepthFirstSearch(row, col - 1);
        DepthFirstSearch(row - 1, col);
        matrix[row, col] = number;
    }

    static void Main()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                number = matrix[row, col];
                area = 0;
                DepthFirstSearch(row, col);
            }
        }

        Console.WriteLine("Largest area: {0}, number: {1}", bestArea, bestNumber);
    }
}
