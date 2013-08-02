using System;

class LastDigitMethod
{
    static string GetLastDigit(int number)
    {
        int lastDigit = number % 10;
        switch (lastDigit)
        {
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "error";
        }
    }

    static void Main()
    {
        Console.Write("Type an integer, please: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Last digit of your integer is {0}", GetLastDigit(num));
    }
}
