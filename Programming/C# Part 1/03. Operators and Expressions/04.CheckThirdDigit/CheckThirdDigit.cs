// 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7.
// E. g. 1732 → true.

using System;

class CheckThirdDigit
{
    static void Main()
    {
        int number;
        
        Console.Write("Enter an integer number: ");

        bool result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input

        if (result)
        {
            int devidedNumber = number / 100;
            int thirdDigit = devidedNumber % 10;

            Console.WriteLine("Is the third digit of ({0}) 7?  -> {1}",
                number, thirdDigit == 7);
        }
        else
        {
            Console.WriteLine("Wrong number!");
        }
    }
}
