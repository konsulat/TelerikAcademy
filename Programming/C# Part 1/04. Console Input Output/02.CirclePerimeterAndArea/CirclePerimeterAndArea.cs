// 02. Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius;
        bool isDouble = false;

        Console.Write("Enter radius: ");

        isDouble = double.TryParse(Console.ReadLine(), out radius); // Checks for valid input

        if (!isDouble || radius <= 0)
        {
            Console.WriteLine("Invalid input!");
            return; // Exits if not valid double
        }

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("Circle's perimeter is {0:0.000} and circle area is {1:0.000}", perimeter, area);
    }
}
