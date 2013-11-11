// 04. Declare an integer variable and assign it with the value 254 in hexadecimal format.
// Use Windows Calculator to find its hexadecimal representation.

using System;

class DeclareHexadecimalNumber
{
    static void Main()
    {
        int hexNumber = 0xFE;
        Console.WriteLine("The hexadecimal representation of 254 is {0:X}", hexNumber);
    }
}
