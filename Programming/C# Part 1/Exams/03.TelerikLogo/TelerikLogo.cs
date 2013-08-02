using System;

class TelerikLogo
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());

        int width = (X / 2 + 1) + X + X + (X / 2 + 1) - 3;

        Console.Write(new string('.', X / 2));
        Console.Write('*');
        int middle = width - 2 * (X / 2 + 1);
        Console.Write(new string('.', middle));
        Console.Write('*');
        Console.WriteLine(new string('.', X / 2));

        int hornLength = X / 2;

        for (int i = 1; i < X - 1; i++)
        {
            if (i <= X / 2 + 1)
            {
                hornLength--;
                if (hornLength > 0)
                {
                    Console.Write(new string('.', hornLength));
                }
                if (hornLength >= 0)
                {
                    Console.Write('*');
                }
                
                Console.Write(new string('.', i - 1));
            }
            else
            {
                Console.Write(new string('.', X / 2));
            }

            Console.Write(new string('.', i));
            Console.Write('*');
            middle -= 2;
            Console.Write(new string('.', middle));
            Console.Write('*');
            Console.Write(new string('.', i));

            if (i <= X / 2 + 1)
            {
                hornLength--;
                if (hornLength > 0)
                {
                    Console.Write(new string('.', hornLength));
                }
                if (hornLength >= 0)
                {
                    Console.Write('*');
                }

                Console.Write(new string('.', i - 1));
            }
            else
            {
                Console.Write(new string('.', X / 2));
            }

            Console.WriteLine();
        }
        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));

        int leftRight = X - 2;
        middle = 1;
        for (int i = 0; i < X - 1; i++)
        {
            Console.Write(new string('.', X / 2));
            Console.Write(new string('.', leftRight));
            Console.Write('*');
            Console.Write(new string('.', middle));
            Console.Write('*');
            Console.Write(new string('.', leftRight));
            Console.Write(new string('.', X / 2));
            Console.WriteLine();

            middle += 2;
            leftRight--;
        }

        middle -= 4;

        for (int i = 1; i <= X - 2; i++)
        {
            Console.Write(new string('.', X / 2));
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', middle));
            Console.Write('*');
            Console.Write(new string('.', i));
            Console.Write(new string('.', X / 2));

            middle -= 2;
            Console.WriteLine();
        }
        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));
    }
}
