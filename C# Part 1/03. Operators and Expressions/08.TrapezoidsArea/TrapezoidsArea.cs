using System;

class TrapezoidsArea
{
    static void Main()
    {
        double aBase;
        double bBase;
        double height;
        bool result;
        Console.Write("Enter the length of the first base of trapezoid: ");
        result = double.TryParse(Console.ReadLine(), out aBase); // Checks for valid input
        if (!result || aBase < 0)
        {
            Console.WriteLine("Wrong first base!");
            return; // Exits if not valid base length
        }
        Console.Write("Enter the length of the second base of trapezoid: ");
        result = double.TryParse(Console.ReadLine(), out bBase); // Checks for valid input
        if (!result || bBase < 0)
        {
            Console.WriteLine("Wrong second base!");
            return; // Exits if not valid base length
        }
        Console.Write("Enter the height of trapezoid: ");
        result = double.TryParse(Console.ReadLine(), out height); // Checks for valid input
        if (!result || height < 0)
        {
            Console.WriteLine("Wrong height!");
            return; // Exits if not valid height
        }
        double area = ((aBase + bBase) / 2) * height;
        Console.WriteLine("Trapezoid's area is {0}", area);
    }
}
