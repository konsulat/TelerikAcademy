using System;

class TrailingZeros
{
    static void Main()
    {
        int n;
        Console.Write("Type a positive integer (N > 0): ");
        bool isInt = int.TryParse(Console.ReadLine(), out n);
        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            int divider = i;
            while (divider % 5 == 0)
            {
                counter++;
                divider /= 5;
            }
        }
        Console.WriteLine("Trailing zeros present at the end of N!: {0}", counter);
    }
}
