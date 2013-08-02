using System;

class Pillars
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = (number >> col) & 1;
            }
        }

        int pillarIndex = 7;
        int countBitsLeft = 0;
        int countBitsRight = 0;
        bool foundSolution = false;

        while (pillarIndex >= 0)
        {
            countBitsLeft = 0;
            countBitsRight = 0;
            for (int col = 0; col < pillarIndex; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        countBitsRight++;
                    }
                }
            }

            for (int col = pillarIndex + 1; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        countBitsLeft++;
                    }
                }
            }

            if (countBitsLeft == countBitsRight)
            {
                foundSolution = true;
                break;
            }

            pillarIndex--;
        }

        if (foundSolution)
        {
            Console.WriteLine(pillarIndex);
            Console.WriteLine(countBitsLeft);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
