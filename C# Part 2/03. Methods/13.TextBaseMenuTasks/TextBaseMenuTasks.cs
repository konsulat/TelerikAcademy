using System;

class TextBaseMenuTasks
{
    static void Main()
    {
        int number;
        bool choise = false;
        do
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Reverses the digits of a number");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3. Solves a linear equation a * x + b = 0");
            Console.Write("Your choise: ");
            choise = int.TryParse(Console.ReadLine(), out number);
            if (!choise || number < 1 || number > 3)
            {
                Console.WriteLine("Invalid choise!!!");
            }
        }
        while (!choise || number < 1 || number > 3);

        switch (number)
        {
            case 1:
                Reverse();
                break;
            case 2:
                Average();
                break;
            case 3:
                LinearEquation();
                break;
            default:
                break;
        }
    }

    private static void Reverse()
    {
        int number;
        bool result = false;
        do
        {
            Console.Write("Enter a positive decimal integer, please: ");
            result = int.TryParse(Console.ReadLine(), out number);
            if (!result || number < 0)
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        while (!result || number < 0);

        while (number != 0)
        {
            int lastDigit = number % 10;
            Console.Write(lastDigit); 
            number /= 10;
        }
        Console.WriteLine();
    }

    private static void Average()
    {
        int length;
        bool result = false;

        do
        {
            Console.Write("Please enter the length of the sequence (should be positive): ");
            result = int.TryParse(Console.ReadLine(), out length);
            if (!result || length <= 0)
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        while (!result || length <= 0);

        decimal average;
        int sum = 0;
        int number;

        for (int i = 0; i < length; i++)
        {
            do
            {
                Console.Write("Enter number {0}: ", i + 1);
                result = int.TryParse(Console.ReadLine(), out number);
                if (!result)
                {
                    Console.WriteLine("Wrong input!!!");
                }
            }
            while (!result);

            sum += number;
        }

        average = (decimal)sum / length;
        Console.WriteLine("The average of the sequence of integers is {0}", average);
    }

    private static void LinearEquation()
    {
        decimal a;
        decimal b;
        bool result = false;

        do
        {
            Console.Write("Enter the coefficient a (should not be zero): ");
            result = decimal.TryParse(Console.ReadLine(), out a);
            if (!result || a == 0)
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        while (!result || a == 0);

        do
        {
            Console.Write("Enter the coefficient b: ");
            result = decimal.TryParse(Console.ReadLine(), out b);
            if (!result)
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        while (!result);

        decimal root = b / a;
        Console.WriteLine("The root of the linear equation {0} * x{1} = 0 is {2:0.000}.",
            a, b != 0 ? " + " + b: "", root);
    }
}
