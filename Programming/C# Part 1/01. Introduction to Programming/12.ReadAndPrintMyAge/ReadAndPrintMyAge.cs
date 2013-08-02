using System;

class ReadAndPrintMyAge
{
    static void Main()
    {
        int age;
        Console.Write("My age now: ");
        bool result = int.TryParse(Console.ReadLine(), out age); // checks for valid data
        if (result && age > 1 && age <= 100) // prints age in 10 years if given age is integer between 1 and 100
        {
            Console.WriteLine("My age in 10 years will be {0}", age + 10);
        }
        else // prints wrong age if given age isn't integer or is <= 0 or > 100 years
        {
            Console.WriteLine("Wrong age!");
        }
    }
}
