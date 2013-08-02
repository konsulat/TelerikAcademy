using System;

class ExchangeSeveralBits
{
    static void Main()
    {
        uint number;
        bool result;
        Console.Write("Enter an unsigned integer number: ");
        result = uint.TryParse(Console.ReadLine(), out number); // Checks for valid input
        if (!result)
        {
            Console.WriteLine("Wrong unsigned integer!");
            return; // Exits if not valid unsigned integer
        }
        Console.WriteLine("Original number:");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int mask = 1 << 3;
        byte thirdBit = (byte)((number & mask) >> 3);
        mask = 1 << 4;
        byte fourthBit = (byte)((number & mask) >> 4);
        mask = 1 << 5;
        byte fifthBit = (byte)((number & mask) >> 5);
        mask = 1 << 24;
        byte twentyFourthBit = (byte)((number & mask) >> 24);
        mask = 1 << 25;
        byte twentyFifthBit = (byte)((number & mask) >> 25);
        mask = 1 << 26;
        int twentySixthBit = (byte)((number & mask) >> 26);

        if (thirdBit == 0)
        {
            number = (uint)(number & ~(1 << 24));
        }
        else if (thirdBit == 1)
        {
            number = (uint)(number | (1 << 24));
        }

        if (twentyFourthBit == 0)
        {
            number = (uint)(number & ~(1 << 3));
        }
        else if (twentyFourthBit == 1)
        {
            number = (uint)(number | (1 << 3));
        }

        if (fourthBit == 0)
        {
            number = (uint)(number & ~(1 << 25));
        }
        else if (fourthBit == 1)
        {
            number = (uint)(number | (1 << 25));
        }

        if (twentyFifthBit == 0)
        {
            number = (uint)(number & ~(1 << 4));
        }
        else if (twentyFifthBit == 1)
        {
            number = (uint)(number | (1 << 4));
        }

        if (fifthBit == 0)
        {
            number = (uint)(number & ~(1 << 26));
        }
        else if (fifthBit == 1)
        {
            number = (uint)(number | (1 << 26));
        }

        if (twentySixthBit == 0)
        {
            number = (uint)(number & ~(1 << 5));
        }
        else if (twentySixthBit == 1)
        {
            number = (uint)(number | (1 << 5));
        }

        Console.WriteLine("New number:");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
