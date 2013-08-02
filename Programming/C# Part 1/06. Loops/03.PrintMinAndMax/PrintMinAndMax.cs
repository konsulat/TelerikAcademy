using System;

class PrintMinAndMax
{
    static void Main()
    {
        int n;
        Console.Write("Type a positive integer: ");
        bool isInt = int.TryParse(Console.ReadLine(), out n);
        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Console.WriteLine("Now type {0} integers (each one on different row)", n);
        int[] numbers = new int[n]; // array with n lenght
        for (int i = 0; i < n; i++)
        {
            isInt = int.TryParse(Console.ReadLine(), out numbers[i]);
            if (!isInt)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }
        int minValue = numbers[0];
        int maxValue = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (minValue > numbers[i])
            {
                minValue = numbers[i];
            }
            if (maxValue < numbers[i])
            {
                maxValue = numbers[i];
            }
        }
        Console.WriteLine("Minimal value: {0}", minValue);
        Console.WriteLine("Maximal value: {0}", maxValue);
    }
}
