// 06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointWithinACircle
{
    static void Main()
    {
        double xCoordinate;
        double yCoordinate;
        double radius = 5.0;
        bool result = false;

        Console.Write("Enter x coordinate of the point: ");

        result = double.TryParse(Console.ReadLine(), out xCoordinate); // Checks for valid input

        if (!result)
        {
            Console.WriteLine("Wrong x coordinate!");
            return; // Exits if not valid x coordinate
        }

        Console.Write("Enter y coordinate of the point: ");

        result = double.TryParse(Console.ReadLine(), out yCoordinate); // Checks for valid input

        if (!result)
        {
            Console.WriteLine("Wrong y coordinate!");
            return; // Exits if not valid y coordinate
        }

        bool inTheCircle = (xCoordinate * xCoordinate) + (yCoordinate * yCoordinate) <= (radius * radius);

        Console.WriteLine("Is point with coordinates ({0}, {1}) within the circle K(0,5)? -> {2}",
            xCoordinate, yCoordinate, inTheCircle);
    }
}
