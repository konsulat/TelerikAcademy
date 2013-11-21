// 10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumWithFixedAccuracy
{
    static void Main()
    {
        decimal previousSum = 1M;
        decimal newSum = 1.5M;
        int denominator = 3;

        while ((decimal)Math.Abs(previousSum - newSum) >= 0.001M) // Sum difference
        {
            previousSum = newSum;

            if (denominator % 2 == 0)
            {
                newSum += 1M / denominator;
            }
            else
            {
                newSum -= 1M / denominator;
            }

            denominator++;
        }

        Console.WriteLine("The sum of the sequence 1 + 1/2 - 1/3 + 1/4 - 1/5... with accuracy of 0.001 is {0}",
            previousSum);
    }
}
