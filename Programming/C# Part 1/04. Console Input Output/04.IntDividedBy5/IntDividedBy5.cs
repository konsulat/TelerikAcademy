// 04. Write a program that reads two positive integer numbers and prints how many numbers p exist
// between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class IntDividedBy5
{
    static void Main()
    {
        int firstInt;
        int secondInt;
        bool isInt = false;

        Console.Write("Enter first integer: ");

        isInt = int.TryParse(Console.ReadLine(), out firstInt); // Checks for valid input

        if (!isInt || firstInt <= 0)
        {
            Console.WriteLine("Invalid intger!");
            return; // Exits if not valid integer
        }

        Console.Write("Enter second integer: ");

        isInt = int.TryParse(Console.ReadLine(), out secondInt); // Checks for valid input

        if (!isInt || secondInt <= 0)
        {
            Console.WriteLine("Invalid intger!");
            return; // Exits if not valid integer
        }

        int tempInt = 0;

        if (firstInt > secondInt) // Swap int if the first is bigger than second
        {
            tempInt = firstInt;
            firstInt = secondInt;
            secondInt = tempInt;
        }

        int counter = 0;

        for (int i = firstInt; i <= secondInt; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        if (counter == 1)
        {
            Console.WriteLine("There is {0} number between ({1}, {2}) (inclusive) divided by 5 without reminder",
           counter, firstInt, secondInt);
        }
        else
        {
            Console.WriteLine("There are {0} numbers between ({1}, {2}) (inclusive) divided by 5 without reminder",
                counter, firstInt, secondInt);
        }
    }
}
