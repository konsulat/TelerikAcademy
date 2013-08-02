using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int firstInt;
        Console.Write("Type a positive integer: ");
        bool isInt = int.TryParse(Console.ReadLine(), out firstInt);
        if (!isInt || firstInt <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        int secondInt;
        Console.Write("Type another positive integer: ");
        isInt = int.TryParse(Console.ReadLine(), out secondInt);
        if (!isInt || secondInt <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (firstInt < secondInt)
        {
            int tempInt = firstInt;
            firstInt = secondInt;
            secondInt = tempInt;
        }

        int remainder = firstInt % secondInt;
        if (remainder == 0)
        {
            Console.WriteLine("Greatest common diviser: {0}", secondInt);
        }
        else
        {
            while (remainder != 0)
            {
                remainder = firstInt % secondInt;
                firstInt = secondInt;
                secondInt = remainder;
            }
            if (secondInt == 0)
            {
                Console.WriteLine("Greatest common diviser: 1");
            }
            else
            {
                Console.WriteLine("Greatest common diviser: {0}", secondInt);
            }
        }
        
    }
}
