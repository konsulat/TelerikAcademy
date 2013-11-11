// 09. Write an expression that checks for given point (x, y) if it is within the circle K((1,1), 3)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointWithinACircleOutOfRectangle
{
    static void Main()
    {
        double xCoordinate;
        double yCoordinate;
        double xCenter = 1.0;
        double yCenter = 1.0;
        double radius = 3.0;
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

        bool inTheCirce = ((xCoordinate - xCenter) * (xCoordinate - xCenter)) +
            ((yCoordinate - yCenter) * (yCoordinate - yCenter)) <= (radius * radius);

        // !!!Rectangle's top left corner has coordinates (1, -1), width = 6, height = 2
        // Points on the rectangle's sides are within the rectangle

        bool inTheRectancle = ((xCoordinate > 1 && xCoordinate < 7) &&
            (yCoordinate > -3 && yCoordinate < -1));

        Console.WriteLine("Is the point with coordinates ({0}, {1}) within the circle K((1, 1), 3) and outside of the rectangle with top left corner's coordinates (1,-1), width = 6, height = 2? -> {2}",
            xCoordinate, yCoordinate, inTheCirce && !inTheRectancle);
    }
}
