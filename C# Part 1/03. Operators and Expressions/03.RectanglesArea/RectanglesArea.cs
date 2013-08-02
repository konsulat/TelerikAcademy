using System;

class RectanglesArea
{
    static void Main()
    {
        double width;
        double height;
        bool result;
        Console.Write("Enter width of the rectangle: ");
        result = double.TryParse(Console.ReadLine(), out width); // Checks for valid input
        if (!result || width < 0)
        {
            Console.WriteLine("Wrong width!");
            return; // Exits if not valid width
        }
        Console.Write("Enter height of the rectangle: ");
        result = double.TryParse(Console.ReadLine(), out height); // Checks for valid input
        if (!result || height < 0)
        {
            Console.WriteLine("Wrong height!");
            return; // Exits if not valid height
        }
        Console.WriteLine("Rectangle's area is {0}", width * height);
    }
}
