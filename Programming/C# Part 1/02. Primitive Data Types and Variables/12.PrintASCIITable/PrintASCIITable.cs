// 12. Find online more information about ASCII (American Standard Code for Information Interchange)
// and write a program that prints the entire ASCII table of characters on the console.

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
