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
        /* using Consolas font in Windows Console to avoid the
           CopyRight Symbol to be displayed incorrectly */
    }
}

