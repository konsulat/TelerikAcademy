using System;

class FirTree
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int leftRightDots = N - 2;
        int firTree = 1;

        for (int i = 0; i < N - 1; i++)
        {
            Console.Write(new string('.', leftRightDots));
            Console.Write(new string('*', firTree));
            Console.Write(new string('.', leftRightDots));

            leftRightDots -= 1;
            firTree += 2;

            Console.WriteLine();
        }
        leftRightDots = N - 2;
        firTree = 1;
        Console.Write(new string('.', leftRightDots));
        Console.Write(new string('*', firTree));
        Console.Write(new string('.', leftRightDots));
        Console.WriteLine();
    }
}
