// 06. Write a program that enters the coefficients a, b and c of a quadratic equation
// a*x2 + b*x + c = 0
// and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a;
        double b;
        double c;
        bool isNumber = false;

        Console.WriteLine("This program will solve quadratic equation a*x^2 + b*x + c = 0");

        Console.Write("Enter coefficient \"a\" = ");

        isNumber = double.TryParse(Console.ReadLine(), out a);

        if (!isNumber)
        {
            Console.WriteLine("Wrong input!");
            return;
        }

        Console.Write("Enter coefficient \"b\" = ");

        isNumber = double.TryParse(Console.ReadLine(), out b);

        if (!isNumber)
        {
            Console.WriteLine("Wrong input!");
            return;
        }

        Console.Write("Enter coefficient \"c\" = ");

        isNumber = double.TryParse(Console.ReadLine(), out c);

        if (!isNumber)
        {
            Console.WriteLine("Wrong input!");
            return;
        }

        double d = b * b - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("Quadratic equation has no real roots");
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Quadratic equation has one real root x = {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("Quadratic equation has two real roots x1 = {0} and x2 = {1}", x1, x2);
        }
    }
}
