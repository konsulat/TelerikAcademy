using System;

class NNumbersSum
{
    static void Main()
    {
        int n;
        bool isInt;
        Console.Write("Input how many numbers we will summarize: ");
        isInt = int.TryParse(Console.ReadLine(), out n);
        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        double sum = 0;
        double number;
        bool isDouble;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Input {0} number for summing: ", i + 1);
            isDouble = double.TryParse(Console.ReadLine(), out number);
            if (!isDouble)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            sum += number;
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}
