// 13.* Write a program that calculates for given N how many trailing zeros present at the end
// of the number N!. Examples:
//	N = 10 → N! = 3628800 → 2
//	N = 20 → N! = 2432902008176640000 → 4
//	Does your program work for N = 50 000?
//	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

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
