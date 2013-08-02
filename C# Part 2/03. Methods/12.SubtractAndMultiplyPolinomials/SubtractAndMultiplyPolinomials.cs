using System;

class SubtractAndMultiplyPolinomials
{
    static int[] SubtractOfPolinomials(int[] firstPolinomial, int[] secondPolinomial)
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

        int[] subtractPolinomial = new int[Math.Max(firstPolinomial.Length, secondPolinomial.Length)];

        for (int i = 0; i < min; i++)
        {
            subtractPolinomial[i] = firstPolinomial[i] - secondPolinomial[i];
        }

        for (int i = min; i < subtractPolinomial.Length; i++)
        {
            if (maxArray == "first")
            {
                subtractPolinomial[i] = firstPolinomial[i];
            }
            else if (maxArray == "second")
            {
                subtractPolinomial[i] = -secondPolinomial[i];
            }
        }

        return subtractPolinomial;
    }

    static int[] MultiplyOfPolinomials(int[] firstPolinomial, int[] secondPolinomial)
    {
        int[] multiplyPolinomial = new int[firstPolinomial.Length + secondPolinomial.Length];

        for (int i = 0; i < firstPolinomial.Length; i++)
        {
            for (int j = 0; j < secondPolinomial.Length; j++)
            {
                int position = i + j;
                multiplyPolinomial[position] += (firstPolinomial[i] * secondPolinomial[j]);
            }
        }

        return multiplyPolinomial;
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

        int[] secondPolinomial = { 7, 6, 3, 5, 4 };
        Console.Write("Second polinomial: ");
        PrintPolinomial(secondPolinomial);

        Console.Write("Substraction of two polinomials (first - second): ");
        PrintPolinomial(SubtractOfPolinomials(firstPolinomial, secondPolinomial));

        Console.Write("Multiplication of two polinomials: ");
        PrintPolinomial(MultiplyOfPolinomials(firstPolinomial, secondPolinomial));
    }
}
