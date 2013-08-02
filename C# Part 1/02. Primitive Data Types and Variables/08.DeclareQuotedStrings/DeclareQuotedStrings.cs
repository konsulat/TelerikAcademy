using System;

class DeclareQuotedStrings
{
    static void Main()
    {
        string qstringFirstWay = "The \"use\" of quotations causes difficulties.";
        string qstringSecondWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("First way is with useing \\ to escape quotes - {0}", qstringFirstWay);
        Console.WriteLine("Second way is with @ and double quotes - {0}", qstringSecondWay);
    }
}
