using System;
using System.Threading;

class MathExpression
{
    static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = 
        string inputN = Console.ReadLine();
        string inputM = Console.ReadLine();
        string inputP = Console.ReadLine();
        double n = double.Parse(inputN);
        double m = double.Parse(inputM);
        double p = double.Parse(inputP);

        const double numberNom = 1337;
        const double numberDenom = 128.523123123;
        double nominator = n * n + 1 / (m * p) + numberNom;
        double denominator = n - numberDenom * p;

    }
}
