using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius;
        bool isDouble;
        Console.Write("Enter radius: ");
        isDouble = double.TryParse(Console.ReadLine(), out radius);
        if (!isDouble || radius <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("Circle's perimeter is {0:0.000} and circle area is {1:0.000}", perimeter, area);
    }
}
