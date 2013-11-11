// 09. Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows
// Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed
// incorrectly.

using System;

class DisplayCopyrightSymbol
{
    static void Main()
    {
        char copyRightSymbol = '\u00A9';
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("  {0}  ", copyRightSymbol);
        Console.WriteLine(" {0}{0}{0} ", copyRightSymbol);
        Console.WriteLine("{0}{0}{0}{0}{0}", copyRightSymbol);
        /* set Consolas font in Windows Console to avoid the
           CopyRight Symbol to be displayed incorrectly */
    }
}

