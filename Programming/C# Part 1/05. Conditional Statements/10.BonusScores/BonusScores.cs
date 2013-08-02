using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter a digit in the range [1..9]: ");
        string inputStr = Console.ReadLine();
        if (inputStr.Length != 1)
        {
            Console.WriteLine("Invalid digit!");
            return;
        }
        char charDigit = char.Parse(inputStr);
        switch (charDigit)
        {
            case '1':
            case '2':
            case '3':
                Console.WriteLine("Bonus score: {0}", int.Parse(charDigit.ToString()) * 10);
                break;
            case '4':
            case '5':
            case '6':
                Console.WriteLine("Bonus score: {0}", int.Parse(charDigit.ToString()) * 100);
                break;
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Bonus score: {0}", int.Parse(charDigit.ToString()) * 1000);
                break;
            default:
                Console.WriteLine("Invalid digit or ziro!");
                break;
        }
    }
}
