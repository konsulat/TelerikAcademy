using System;

class SumPolynomials
{
    static int[] SumOfPolinomials(int[] firstPolinomial, int[] secondPolinomial)
    {
        int min = 0;
        string maxArray = "";

        if (firstPolinomial.Length > secondPolinomial.Length)
        {
            min = secondPolinomial.Length;
            maxArray = "first";
        }
        else
        {
            min = firstPolinomial.Length;
            maxArray = "second";
        }

        int[] sumPolinomial = new int[Math.Max(firstPolinomial.Length, secondPolinomial.Length)];

        for (int i = 0; i < min; i++)
        {
            sumPolinomial[i] = firstPolinomial[i] + secondPolinomial[i];
        }

        for (int i = min; i < sumPolinomial.Length; i++)
        {
            if (maxArray == "first")
            {
                sumPolinomial[i] = firstPolinomial[i];
            }
            else if (maxArray == "second")
            {
                sumPolinomial[i] = secondPolinomial[i];
            }
        }

        return sumPolinomial;
    }

    static void PrintPolinomial(int[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0)
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x{0}+",
                        i == 1 ? "" : "^" + i, polinomial[i] == 1 ? "" : polinomial[i].ToString());
                }
                else
                {
                    Console.Write("{1}x{0}",
                        i == 1 ? "" : "^" + i, polinomial[i] == 1 ? "" : polinomial[i].ToString());
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] firstPolinomial = { 4, 0, -2, 1 };
        Console.Write("First polinomial: ");
        PrintPolinomial(firstPolinomial);

        int[] secondPolinomial = { 5, 4 };
        Console.Write("Second polinomial: ");
        PrintPolinomial(secondPolinomial);

        Console.Write("Sum of two polinomials: ");
        PrintPolinomial(SumOfPolinomials(firstPolinomial, secondPolinomial));
    }
}
