// 12.* Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class ReadAndPrintMyAge
{
    static void Main()
    {
        byte age; // no negative values allowed
        Console.Write("My age now: ");
        bool result = byte.TryParse(Console.ReadLine(), out age); // checks for valid data
        if (result && age <= 120) // prints age in 10 years if given age is no negative, equal or smaller than 120
        {
            Console.WriteLine("My age in 10 years will be {0}", age + 10);
        }
        else // prints wrong age if given age is negative or bigger than 120 
        {
            Console.WriteLine("Wrong age!");
        }
    }
}
