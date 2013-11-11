// 05. Declare a character variable and assign it with the symbol that has Unicode code 72.
// Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class DeclareCharacterVariable
{
    static void Main()
    {
        char charVariable = '\u0048';
        Console.WriteLine("The Unicode symbol that has code 72 is {0}", charVariable);
    }
}
