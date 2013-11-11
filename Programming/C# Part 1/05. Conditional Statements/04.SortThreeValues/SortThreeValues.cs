// 04. Sort 3 real values in descending order using nested if statements.

using System;

class SortThreeValues
{
    static void Main()
    {
        double firstDouble;
        double secondDouble;
        double thirdDouble;
        bool isDouble = false;

        Console.Write("Type first real number: ");

        isDouble = double.TryParse(Console.ReadLine(), out firstDouble);

        if (!isDouble)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Type second real number: ");

        isDouble = double.TryParse(Console.ReadLine(), out secondDouble);

        if (!isDouble)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Type third real number: ");

        isDouble = double.TryParse(Console.ReadLine(), out thirdDouble);

        if (!isDouble)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (firstDouble >= secondDouble)
        {
            if (firstDouble >= thirdDouble)
            {
                if (secondDouble >= thirdDouble)
                {
                    Console.WriteLine("Sorted real numbers in descending order are {0}, {1}, {2}",
                    firstDouble, secondDouble, thirdDouble);
                }
                else
                {
                    Console.WriteLine("Sorted real numbers in descending order are {0}, {1}, {2}",
                    firstDouble, thirdDouble, secondDouble);
                }
            }
            else
            {
                Console.WriteLine("Sorted real numbers in descending order are {0}, {1}, {2}",
                    thirdDouble, firstDouble, secondDouble);
            }
        }
        else
        {
            if (thirdDouble >= secondDouble)
            {
                Console.WriteLine("Sorted real numbers in descending order are {0}, {1}, {2}",
                    thirdDouble, secondDouble, firstDouble);
            }
            else
            {
                if (thirdDouble >= firstDouble)
                {
                    Console.WriteLine("Sorted real numbers in descending order are {0}, {1}, {2}",
                    secondDouble, thirdDouble, firstDouble);
                }
                else
                {
                    Console.WriteLine("Sorted real numbers in descending order are {0}, {1}, {2}",
                    secondDouble, firstDouble, thirdDouble);
                }
            }
        }
    }
}
