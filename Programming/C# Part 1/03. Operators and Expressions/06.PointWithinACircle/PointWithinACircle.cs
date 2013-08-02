using System;

class PointWithinACircle
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
        bool inTheCircle = (xCoordinate * xCoordinate) + (yCoordinate * yCoordinate) <= (5.0 * 5.0);
        if (inTheCircle)
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K(0,5)", xCoordinate, yCoordinate);
        }
        else
	    {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is out of the circle K(0,5)", xCoordinate, yCoordinate);
	    }
    }
}
