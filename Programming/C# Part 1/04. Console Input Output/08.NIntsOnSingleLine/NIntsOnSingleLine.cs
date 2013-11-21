// 08. Write a program that reads an integer number n from the console and prints all the numbers in
// the interval [1..n], each on a single line.

using System;

class NIntsOnSingleLine
{
    static void Main()
    {
        int n;
        bool isInt = false;

        Console.Write("Input how many numbers we will print: ");

        isInt = int.TryParse(Console.ReadLine(), out n); // Checks for valid input

        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return; // Exits if not valid integer
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
