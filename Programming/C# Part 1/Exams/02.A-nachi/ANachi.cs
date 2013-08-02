using System;

class ANachi
{
    static void Main()
    {
        int shift = 64;
        string firstMember = Console.ReadLine();
        int first = firstMember[0] - shift;

        string secondMember = Console.ReadLine();
        int second = secondMember[0] - shift;

        int rowsNumber = int.Parse(Console.ReadLine());

        Console.WriteLine((char)(first + shift));

        if (rowsNumber > 1)
        {
            int next = first + second;
            if (next > 26)
            {
                next = next % 26;
            }
            first = second;
            second = next;
            Console.WriteLine("{0}{1}", (char)(first + shift), (char)(next + shift));

            for (int i = 3; i <= rowsNumber; i++)
            {
                next = first + second;
                if (next > 26)
                {
                    next = next % 26;
                }
                first = second;
                second = next;
                next = first + second;
                if (next > 26)
                {
                    next = next % 26;
                }
                first = second;
                second = next;
                Console.Write((char)(first + shift));
                Console.Write(new String(' ', i - 2));
                Console.WriteLine((char)(second + shift));
            }
        }

    }
}

