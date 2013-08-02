using System;

class GreaterNumWithoutIf
{
    static void Main()
    {
        double firstNumber;
        double secondNumber;

        do
        {
            Console.Write("Enter first number: ");
        }
        while (!double.TryParse(Console.ReadLine(), out firstNumber));
        do
        {
            Console.Write("Enter second number: ");
        }
        while (!double.TryParse(Console.ReadLine(), out secondNumber));

        Console.WriteLine("The greater number is {0}", Math.Max(firstNumber, secondNumber));
    }
}
