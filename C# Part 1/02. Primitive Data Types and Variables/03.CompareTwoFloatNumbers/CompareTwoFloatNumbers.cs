using System;

class CompareTwoFloatNumbers
{
    static void Main()
    {
        float firstNumber;
        float secondNumber;
        bool result;
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
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("Two float numbers are equal");
        }
        else
        {
            Console.WriteLine("Two float numbers are not equal");
        }
    }
}
