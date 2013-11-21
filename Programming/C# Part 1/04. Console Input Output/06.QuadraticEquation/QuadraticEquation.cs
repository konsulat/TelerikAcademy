// 06. Write a program that reads the coefficients a, b and c of a quadratic equation ax^2+bx+c=0
// and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a;
        double b;
        double c;
        bool isNumber = false;

        Console.WriteLine("This program will solve quadratic equation ax^2 + bx + c = 0");
        Console.Write("Enter coefficient \"a\" = ");

        isNumber = double.TryParse(Console.ReadLine(), out a); // Checks for valid input

        if (!isNumber)
        {
            Console.WriteLine("Wrong input!");
            return; // Exits if not valid double
        }

        Console.Write("Enter coefficient \"b\" = ");

        isNumber = double.TryParse(Console.ReadLine(), out b); // Checks for valid input

        if (!isNumber)
        {
            Console.WriteLine("Wrong input!");
            return; // Exits if not valid double
        }

        Console.Write("Enter coefficient \"c\" = ");

        isNumber = double.TryParse(Console.ReadLine(), out c); // Checks for valid input

        if (!isNumber)
        {
            Console.WriteLine("Wrong input!");
            return; // Exits if not valid double
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("Quadratic equation has no real roots");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Quadratic equation has one real root x = {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Quadratic equation has two real roots x1 = {0} and x2 = {1}", x1, x2);
        }
    }
}
