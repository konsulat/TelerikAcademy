using System;

class NameOfDigit
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        string inputStr = Console.ReadLine();
        if (inputStr.Length != 1)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        char charDigit = char.Parse(inputStr);
        switch (charDigit)
        {
            case '0': Console.WriteLine("You typed zero"); break;
            case '1': Console.WriteLine("You typed one"); break;
            case '2': Console.WriteLine("You typed two"); break;
            case '3': Console.WriteLine("You typed three"); break;
            case '4': Console.WriteLine("You typed four"); break;
            case '5': Console.WriteLine("You typed five"); break;
            case '6': Console.WriteLine("You typed six"); break;
            case '7': Console.WriteLine("You typed seven"); break;
            case '8': Console.WriteLine("You typed eight"); break;
            case '9': Console.WriteLine("You typed nine"); break;
            default: Console.WriteLine("You didn't type a digit!"); break;
        }
    }
}
