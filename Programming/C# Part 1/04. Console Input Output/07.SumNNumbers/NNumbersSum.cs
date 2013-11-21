// 07. Write a program that gets a number n and after that gets more n numbers and calculates and prints
// their sum. 

using System;

class NNumbersSum
{
    static void Main()
    {
        int n;
        bool isInt = false;

        Console.Write("Input how many numbers we will summarize: ");

        isInt = int.TryParse(Console.ReadLine(), out n); // Checks for valid input

        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return; // Exits if not valid integer
        }

        double sum = 0;
        double number;
        bool isDouble = false;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Input {0} number for summing: ", i + 1);

            isDouble = double.TryParse(Console.ReadLine(), out number); // Checks for valid input

            if (!isDouble)
            {
                Console.WriteLine("Invalid input!");
                return; // Exits if not valid double
            }

            sum += number;
        }

        Console.WriteLine("The sum is {0}", sum);
    }
}
