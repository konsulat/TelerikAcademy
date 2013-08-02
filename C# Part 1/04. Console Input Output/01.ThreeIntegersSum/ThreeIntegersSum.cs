using System;

class ThreeIntegersSum
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        bool isInt;
        Console.Write("Enter first integer: ");
        isInt = int.TryParse(Console.ReadLine(), out firstNumber);
        if (!isInt)
        {
            Console.WriteLine("Wrong integer!");
            return;
        }
        Console.Write("Enter second integer: ");
        isInt = int.TryParse(Console.ReadLine(), out secondNumber);
        if (!isInt)
        {
            Console.WriteLine("Wrong integer!");
            return;
        }
        Console.Write("Enter third integer: ");
        isInt = int.TryParse(Console.ReadLine(), out thirdNumber);
        if (!isInt)
        {
            Console.WriteLine("Wrong integer!");
            return;
        }
        long sum = (long)(firstNumber + secondNumber + thirdNumber);
        Console.WriteLine("The sum of the three integers is: {0}", sum);
    }
}
