// 13. Create a program that assigns null values to an integer and to double variables. Try to print
// them on the console, try to add some values or the null literal to them and see the result.

using System;

class CreateNullVariables
{
    static void Main()
    {
        int? nullInt = null;
        Console.WriteLine("This is an integer with null value: {0}", nullInt);
        Console.WriteLine("After adding 5 to the null integer: {0}", nullInt + 5);
        Console.WriteLine("After adding null to the null integer: {0}", nullInt + null);

        double? nullDouble = null;
        Console.WriteLine("This is a double with null value: {0}", nullDouble);
        Console.WriteLine("After adding 3.0 to the null double: {0}", nullDouble + 3.0);
        Console.WriteLine("After adding null to the null double: {0}", nullDouble + null);
    }
}
