// 03. Write a program that safely compares floating-point numbers with precision of 0.000001.
// Examples:(5.3 ; 6.01) → false;  (5.00000001 ; 5.00000003) → true

using System;

class CompareTwoFloatNumbers
{
    static void Main()
    {
        float firstNumber;
        float secondNumber;
        bool result = false;

        Console.WriteLine("Safely compare two float numbers with precision of 0.000001");
        
        Console.Write("Enter first float number: ");
        result = float.TryParse(Console.ReadLine(), out firstNumber); // Checks for valid first number
        if (!result)
        {
            Console.WriteLine("Wrong float!");
            return;
        }

        Console.Write("Enter second float number: ");
        result = float.TryParse(Console.ReadLine(), out secondNumber); // Checks for valid second number
        if (!result)
        {
            Console.WriteLine("Wrong float!");
            return;
        }

        Console.WriteLine("({0:F6} ; {1:F6}) -> {2}", firstNumber, secondNumber,
            Math.Abs(firstNumber - secondNumber) < 0.000001F);
    }
}
