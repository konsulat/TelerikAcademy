using System;

class ReverseDigits
{
    static string Reverse(int number)
    {
        if (number < 0)
        {
            number *= -1;
        }

        string reversed = "";
        while (number != 0)
        {
            int lastDigit = number % 10;
            reversed += lastDigit.ToString();
            number /= 10;
        }
        return reversed;
    }

    static void Main()
    {
        Console.Write("Type a decimal integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number is: {0}", Reverse(number));
    }
}
