using System;

class FireInTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = (n / 2) - 1;
        int innerDots = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}#{1}{1}#{0}", new string('.', outerDots), new string('.', innerDots));
            outerDots--;
            innerDots++;
        }
        for (int i = 0; i < n / 4; i++)
        {
            outerDots++;
            innerDots--;
            Console.WriteLine("{0}#{1}{1}#{0}", new string('.', outerDots), new string('.', innerDots));  
        }
        Console.WriteLine(new string('-', n));

        int otherSlash = n / 2;
        int slash = n / 2;
        int dot = 0;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{0}", new string('.', dot), new string('\\', otherSlash),
                new string('/', slash));
            dot++;
            otherSlash--;
            slash--;
        }
    }
}
