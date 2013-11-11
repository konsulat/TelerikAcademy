// 03. Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestOfThreeInts
{
    static void Main()
    {
        int firstInteger;
        int secondInteger;
        int thirdInteger;
        bool isInt = false;

        Console.Write("Enter first integer number: ");

        isInt = int.TryParse(Console.ReadLine(), out firstInteger);

        if (!isInt)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Enter second integer number: ");

        isInt = int.TryParse(Console.ReadLine(), out secondInteger);

        if (!isInt)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Enter third integer number: ");

        isInt = int.TryParse(Console.ReadLine(), out thirdInteger);

        if (!isInt)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (firstInteger >= secondInteger)
        {
            if (firstInteger >= thirdInteger)
            {
                Console.WriteLine("The biggest integer is: {0}", firstInteger);
            }
            else
            {
                Console.WriteLine("The biggest integer is: {0}", thirdInteger);
            }
        }
        else
        {
            if (secondInteger >= thirdInteger)
            {
                Console.WriteLine("The biggest integer is: {0}", secondInteger);
            }
            else
            {
                Console.WriteLine("The biggest integer is: {0}", thirdInteger);
            }
        }
    }
}
