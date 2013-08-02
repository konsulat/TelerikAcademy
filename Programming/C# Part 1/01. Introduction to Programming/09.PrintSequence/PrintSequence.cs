using System;

class PrintSequence
{
    static void Main()
    {
        Console.WriteLine("The first 10 members of sequence are:");
        for (int i = 0; i < 10; i++) // loop for the first 10 members
        {
            Console.WriteLine((i + 2) * Math.Pow(-1, i));
        }
    }
}
