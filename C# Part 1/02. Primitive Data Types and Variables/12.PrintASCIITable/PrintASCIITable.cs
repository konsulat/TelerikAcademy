using System;

class PrintASCIITable
{
    static void Main()
    {
        Console.WriteLine("ASCII Table");
        for (int character = 0; character < 128; character++)
        {
            char symbol = (char)character;
            Console.WriteLine("Code: {0} - Symbol: {1}", character, symbol);
        }
        /* Note: Some symbols don't have visual representation */
    }
}
