// 08. Write a program that calculates the greatest common divisor (GCD) of given two numbers.
// Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int firstInt;
        bool isInt = false;

        Console.Write("Type a positive integer: ");

        isInt = int.TryParse(Console.ReadLine(), out firstInt);

        if (!isInt || firstInt <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int secondInt;

        Console.Write("Type another positive integer: ");

        isInt = int.TryParse(Console.ReadLine(), out secondInt);

        if (!isInt || secondInt <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (firstInt < secondInt)
        {
            int tempInt = firstInt;
            firstInt = secondInt;
            secondInt = tempInt;
        }

        int result = 0;
        int remainder = 0;

        do
        {
            result = firstInt / secondInt;
            remainder = firstInt % secondInt;

            Console.WriteLine("{0} = {1} x {2} + {3}",
                    firstInt, result, secondInt, remainder);

            firstInt = secondInt;
            secondInt = remainder;
        }
        while (remainder != 0);

        Console.WriteLine("The Greatest Common Divider is: {0}", firstInt);
    }
}
