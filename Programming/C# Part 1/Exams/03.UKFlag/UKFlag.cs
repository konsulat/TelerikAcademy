using System;

class UKFlag
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int innerDots = (N / 2) - 1;
        int outerDots = 0;

        for (int i = 0; i < N / 2; i++)
        {
            Console.WriteLine("{0}\\{1}|{1}/{0}",
                new string('.', outerDots), new string('.', innerDots));
            innerDots--;
            outerDots++;
        }
        Console.WriteLine("{0}*{0}", new string('-', N / 2));        
        for (int i = 0; i < N / 2; i++)
        {
            outerDots--;
            innerDots++;
            Console.WriteLine("{0}/{1}|{1}\\{0}",
                new string('.', outerDots), new string('.', innerDots));
        }
    }
}
