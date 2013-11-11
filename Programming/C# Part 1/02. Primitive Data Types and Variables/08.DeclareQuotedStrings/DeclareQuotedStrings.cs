// 08. Declare two string variables and assign them with following value:
//
// The "use" of quotations causes difficulties.
//
// Do the above in two different ways: with and without using quoted strings.

using System;

class DeclareQuotedStrings
{
    static void Main()
    {
        string qstringFirstWay = "The \"use\" of quotations causes difficulties.";
        string qstringSecondWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("First way is with useing \\\\ to escape quotes - {0}", qstringFirstWay);
        Console.WriteLine("Second way is with @ and double quotes - {0}", qstringSecondWay);
    }
}
