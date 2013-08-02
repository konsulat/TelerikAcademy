using System;

class SevenlandNumbers
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int decimalNumber = 0;
        int power = 0;

        while (inputNumber != 0)
        {
            int lastDigit = inputNumber % 10;
            decimalNumber += lastDigit * (int)Math.Pow(7, power);
            power++;
            inputNumber /= 10;
        }
        decimalNumber++;
        string result = "";
        while (decimalNumber != 0)
        {
            int lastDigit = decimalNumber % 7;
            result = lastDigit + result;
            decimalNumber /= 7;
        }
        Console.WriteLine(result);
    }
}
