using System;

class NeuronMapping
{
    static void Main()
    {
        int[,] matrix = new int[32, 32];
        int currentInt = int.Parse(Console.ReadLine());
        int counter = 0;
        while (currentInt != -1)
        {
            for (int col = 0; col < 32; col++)
            {
                matrix[counter, col] = (currentInt >> col) & 1;
            }
            currentInt = int.Parse(Console.ReadLine());
            counter++;
        }

        for (int row = 0; row < 32; row++)
        {
            for (int col = 0; col < 32; col++)
            {
                if (matrix[row, col] == 1)
                {
                    matrix[row, col] = 0;
                    if (col <  31 && matrix[row, col + 1] == 1)
                    {
                        while (matrix[row, col + 1] == 1)
                        {
                            matrix[row, col] = 0;
                            col++;
                        }
                    }
                }
                else
                {
                    while (matrix[row, col] == 0)
                    {
                        matrix[row, col] = 1;
                        col++;
                    }
                    
                }
            }
        }
        Console.WriteLine();
    }
}
