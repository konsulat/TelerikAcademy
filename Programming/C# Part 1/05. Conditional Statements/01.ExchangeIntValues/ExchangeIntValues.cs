// 01. Write an if statement that examines two integer variables and exchanges their values
// if the first one is greater than the second one.

using System;

class ExchangeIntValues
{
    static void Main()
    {
        int firstInteger;
        int secondInteger;
        int tempInteger = 0;
        bool isInt = false;

        Console.Write("Enter an integer number: ");

        isInt = int.TryParse(Console.ReadLine(), out firstInteger);

        if (!isInt)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Enter another integer number: ");

        isInt = int.TryParse(Console.ReadLine(), out secondInteger);

        if (!isInt)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (firstInteger > secondInteger)
        {
            tempInteger = firstInteger;
            firstInteger = secondInteger;
            secondInteger = tempInteger;
        }

        Console.WriteLine("Exchanged values if the first integer is greater than the second one or original if not");
        Console.WriteLine("First integer: {0}, second integer: {1}", firstInteger, secondInteger);
    }
}
