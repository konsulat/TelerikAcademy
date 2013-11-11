// 02. Which of the following values can be assigned to a variable of type float and which to
// a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatAndDoubleVariables
{
    static void Main()
    {
        double firstVariable = 34.567839023;
        float secondVariable = 12.345f;
        double thirdVariable = 8923.1234857;
        float fourthVariable = 3456.091f;
        Console.WriteLine("First variable {0} is a double number", firstVariable);
        Console.WriteLine("Second variable {0} is a float number", secondVariable);
        Console.WriteLine("Third variable {0} is a double number", thirdVariable);
        Console.WriteLine("Fourth variable {0} is a float number", fourthVariable);
    }
}
