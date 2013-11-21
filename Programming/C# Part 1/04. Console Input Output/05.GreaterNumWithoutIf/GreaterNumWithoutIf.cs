// 05. Write a program that gets two numbers from the console and prints the greater of them. Don’t use
// if statements.

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
        while (!double.TryParse(Console.ReadLine(), out firstNumber)); // Checks for valid input

        do
        {
            Console.Write("Enter second number: ");
        }
        while (!double.TryParse(Console.ReadLine(), out secondNumber)); // Checks for valid input

        Console.WriteLine("The greater number is {0}", Math.Max(firstNumber, secondNumber));
    }
}
