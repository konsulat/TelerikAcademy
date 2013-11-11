// 14.* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given
// 32-bit unsigned integer.

using System;

class ExchangeMultipleBits
{
    static void Main()
    {
        uint number;
        byte p, q, k;

        Console.Write("Enter an unsigned integer number: ");

        bool isNumberValid = uint.TryParse(Console.ReadLine(), out number); // Checks for valid input

        Console.WriteLine("Position p, position q and k positions to change");
        Console.WriteLine("p < q, q + k < 32, p + k < q");
        Console.Write("Enter p: ");
        bool isPValid = byte.TryParse(Console.ReadLine(), out p); // Checks for valid input
        Console.Write("Enter q: ");
        bool isQValid = byte.TryParse(Console.ReadLine(), out q); // Checks for valid input
        Console.Write("Enter k: ");
        bool isKValid = byte.TryParse(Console.ReadLine(), out k); // Checks for valid input

        if (isNumberValid && isPValid && isQValid && isKValid &&
            (p < q) && (q + k < 32) && (p + k < q))
        {
            Console.WriteLine("Original number:");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            for (int i = 0; i < k; i++)
            {
                int maskP = 1 << (p + i);
                byte pBit = (byte)((number & maskP) >> (p + i));
                int maskQ = 1 << (q + i);
                byte qBit = (byte)((number & maskQ) >> (q + i));

                if (pBit == 0)
                {
                    number = (uint)(number & ~(1 << (q + i)));
                }
                else if (pBit == 1)
                {
                    number = (uint)(number | (1 << (q + i)));
                }

                if (qBit == 0)
                {
                    number = (uint)(number & ~(1 << (p + i)));
                }
                else if (qBit == 1)
                {
                    number = (uint)(number | (1 << (p + i)));
                }
            }

            Console.WriteLine("New number:");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }

    }
}