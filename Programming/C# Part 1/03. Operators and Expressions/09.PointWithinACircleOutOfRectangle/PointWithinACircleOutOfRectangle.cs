using System;

class PointWithinACircleOutOfRectangle
{
    static void Main()
    {
        double xCoordinate;
        double yCoordinate;
        bool result;
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

        bool inTheCirce = ((xCoordinate - 1) * (xCoordinate - 1)) +
            ((yCoordinate - 1) * (yCoordinate - 1)) <= (3 * 3);

        // !!!Rectangle's top left corner has coordinates (1, -1), width = 6, height = 2
        // Points on the rectangle's sides are within the rectangle

        bool outOfTheRectancle = ((xCoordinate < 1 || xCoordinate > 7) &&
            (yCoordinate > -1 || yCoordinate < -3));
        if (inTheCirce && outOfTheRectancle)
        {
            Console.WriteLine("The point with coordinates x: {0} and y: {1} is within the circle K((1,1),3) and outside of the rectangle with top left corner's coordinates (1,-1), width = 6, height = 2",
                xCoordinate, yCoordinate);
        }
        else
        {
            Console.WriteLine("The point with coordinates x: {0} and y: {1} isn't within the circle K((1,1),3) or outside of the rectangle with top left corner's coordinates (1,-1), width = 6, height = 2",
                xCoordinate, yCoordinate);
        }
    }
}
