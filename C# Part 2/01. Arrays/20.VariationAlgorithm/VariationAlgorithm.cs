using System;

class VariationAlgorithm
{
    static void Variate(int[] numbers, int index, int n)
    {
        if (index == numbers.Length)
        {
            Console.Write("{");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("}");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                numbers[index] = i;
                Variate(numbers, index + 1, n);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K (K <= N): ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[k];

        Variate(numbers, 0, n);
    }
}
