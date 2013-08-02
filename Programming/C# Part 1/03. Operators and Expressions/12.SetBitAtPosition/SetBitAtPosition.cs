using System;

class SetBitAtPosition
{
    static void Main()
    {
        int number;
        byte value;
        byte position;
        bool result;
        Console.Write("Enter an integer number: ");
        result = int.TryParse(Console.ReadLine(), out number); // Checks for valid input
        if (!result)
        {
            Console.WriteLine("Wrong integer!");
            return; // Exits if not valid integer
        }
        Console.Write("Enter value: ");
        result = byte.TryParse(Console.ReadLine(), out value); // Checks for valid input
        if (!result || (value != 0 && value != 1))
        {
            Console.WriteLine("Wrong value!");
            return; // Exits if not valid value
        }
        Console.Write("Enter position: ");
        result = byte.TryParse(Console.ReadLine(), out position); // Checks for valid input
        if (!result || position >= 32)
        {
            Console.WriteLine("Wrong position!");
            return; // Exits if not valid position
        }

        if (value == 0)
        {
            int mask = ~(1 << position);
            int newNumber = number & mask;
            Console.WriteLine("New integer after setting bit at position {0} to 0 is {1}", position, newNumber);
        }
        else
        {
            int mask = 1 << position;
            int newNumber = number | mask;
            Console.WriteLine("New integer after setting bit at position {0} to 1 is {1}", position, newNumber);
        }
    }
}
