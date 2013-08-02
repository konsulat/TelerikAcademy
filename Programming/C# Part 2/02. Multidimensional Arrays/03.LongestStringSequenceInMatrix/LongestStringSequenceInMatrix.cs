using System;

class LongestStringSequenceInMatrix
{
    static void Main()
    {
        /*
        string[,] matrix = {{"ha", "fifi", "ho", "hi"},
                            {"fo", "ha", "hi", "xx"},
                            {"xxx", "ho", "ha", "xx"}};
        
        string[,] matrix = {{"s", "qq", "s"},
                            {"pp", "pp", "s"},
                            {"pp", "qq", "s"}};
        */
        string[,] matrix = {{"pp", "qq", "s"},
                            {"pp", "s", "s"},
                            {"s", "qq", "qq"}};

        int bestSeq = 1;
        int currentSeq = 1;
        string bestElement = matrix[0, 0];
        
        // Checks rows
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (bestSeq < currentSeq)
                {
                    bestSeq = currentSeq;
                    bestElement = matrix[row, col];
                }
            }
            currentSeq = 1;
        }


        // Checks cols
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (bestSeq < currentSeq)
                {
                    bestSeq = currentSeq;
                    bestElement = matrix[row, col];
                }
            }
            currentSeq = 1;
        }

        // Checks diagonals
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                for (int currentRow = row, currentCol = col; currentRow < matrix.GetLength(0) - 1 && currentCol < matrix.GetLength(1) - 1; currentRow++, currentCol++)
                {
                    if (matrix[currentRow, currentCol] == matrix[currentRow + 1, currentCol + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (bestSeq < currentSeq)
                    {
                        bestSeq = currentSeq;
                        bestElement = matrix[row, col];
                    }
                }
                currentSeq = 1;
            }
        }

        // Checks other diagonals
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 0 ; col--)
            {
                for (int currentRow = row, currentCol = col; currentRow < matrix.GetLength(0) - 1 && currentCol > 0; currentRow++, currentCol--)
                {
                    if (matrix[currentRow, currentCol] == matrix[currentRow + 1, currentCol - 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (bestSeq < currentSeq)
                    {
                        bestSeq = currentSeq;
                        bestElement = matrix[row, col];
                    }
                }
                currentSeq = 1;
            }
        }

        Console.WriteLine("Longest sequence: {0}", bestSeq);
        for (int i = 0; i < bestSeq; i++)
        {
            if (i != 0)
            {
                Console.Write(", ");
            }
            Console.Write(bestElement);
        }
        Console.WriteLine();
    }
}
