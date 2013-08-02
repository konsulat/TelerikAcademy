﻿using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());
        long fourthNumber = long.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        if (cols == 4)
        {
            Console.Write(firstNumber + " " + secondNumber + " " + thirdNumber + " " + fourthNumber);
        }
        else
        {
            Console.Write(firstNumber + " " + secondNumber + " " + thirdNumber + " " + fourthNumber + " ");
        }

        long result = 0;
        for (int row = 0; row < rows; row++)
        {
            if (row == 0)
            {
                for (int col = 4; col < cols; col++)
                {
                    result = firstNumber + secondNumber + thirdNumber + fourthNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = fourthNumber;
                    fourthNumber = result;

                    if (col + 1 == cols)
                    {
                        Console.Write(result);
                    }
                    else
                    {
                        Console.Write(result + " ");
                    }
                }
            }
            else
            {
                for (int col = 0; col < cols; col++)
                {
                    result = firstNumber + secondNumber + thirdNumber + fourthNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = fourthNumber;
                    fourthNumber = result;

                    if (col + 1 == cols)
                    {
                        Console.Write(result);
                    }
                    else
                    {
                        Console.Write(result + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}