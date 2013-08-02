using System;

class TribonacciTriangle
{
    static void Main()
    {
        long firstMember = long.Parse(Console.ReadLine());
        long secondMember = long.Parse(Console.ReadLine());
        long thirdMember = long.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        Console.WriteLine(firstMember);
        Console.WriteLine(secondMember + " " + thirdMember);

        long nextMember = 0;
        for (int row = 3; row <= lines; row++)
        {
            for (int col = 0; col < row; col++)
            {
                nextMember = firstMember + secondMember + thirdMember;
                firstMember = secondMember;
                secondMember = thirdMember;
                thirdMember = nextMember;
                Console.Write("{0}", nextMember);
                if (col != row - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}