// 09. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintSequence
{
    static void Main()
    {
        Console.WriteLine("The first 10 members of sequence are:");
        for (int i = 2; i <= 11; i++) // loop for the first 10 members
        {
            Console.WriteLine(i * Math.Pow(-1, i));
        }
    }
}
