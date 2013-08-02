using System;

class IntDividedBy5
{
    static void Main()
    {
        int firstInt;
        int secondInt;
        bool isInt;
        Console.Write("Enter first integer: ");
        isInt = int.TryParse(Console.ReadLine(), out firstInt);
        if (!isInt)
        {
            Console.WriteLine("Invalid intger!");
            return;
        }
        Console.Write("Enter second integer: ");
        isInt = int.TryParse(Console.ReadLine(), out secondInt);
        if (!isInt)
        {
            Console.WriteLine("Invalid intger!");
            return;
        }

        int tempInt;
        if (firstInt > secondInt)
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
