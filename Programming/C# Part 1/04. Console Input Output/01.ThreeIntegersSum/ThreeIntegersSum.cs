// 01. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ThreeIntegersSum
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        bool isInt = false;

        Console.Write("Enter first integer: ");

        isInt = int.TryParse(Console.ReadLine(), out firstNumber); // Checks for valid input

        if (!isInt)
        {
            Console.WriteLine("Wrong integer!");
            return; // Exits if not valid integer
        }

        Console.Write("Enter second integer: ");

        isInt = int.TryParse(Console.ReadLine(), out secondNumber); // Checks for valid input

        if (!isInt)
        {
            Console.WriteLine("Wrong integer!");
            return; // Exits if not valid integer
        }

        Console.Write("Enter third integer: ");

        isInt = int.TryParse(Console.ReadLine(), out thirdNumber); // Checks for valid input

        if (!isInt)
        {
            Console.WriteLine("Wrong integer!");
            return; // Exits if not valid integer
        }

        // The sum may overflow the int type, so it should be cast as long
        // E.g. firstNumber = 2000000000, secondNumber = 2000000000, thirdNumber = 0
        // All three num are valid ints, but the sum isn't
        long sum = ((long)firstNumber + (long)secondNumber + (long)thirdNumber);

        Console.WriteLine("The sum of the three integers is: {0}", sum);
    }
}
