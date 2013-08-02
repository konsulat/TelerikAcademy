using System;

class CheckThirdDigit
{
    static void Main()
    {
        int number;
        bool result;
        Console.Write("Enter an integer number: ");
        result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input
        if (result)
        {
            int devidedNumber = number / 100;
            int thirdDigit = devidedNumber % 10;
            if (thirdDigit == 7)
            {
                Console.WriteLine("Third digit is 7"); 
            }
            else
            {
                Console.WriteLine("Third digit isn't 7");
            }
        }
        else
        {
            Console.WriteLine("Wrong number!");
        }
    }
}
