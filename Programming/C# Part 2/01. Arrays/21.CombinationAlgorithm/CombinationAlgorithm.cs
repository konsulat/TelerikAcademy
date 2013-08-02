using System;

class CombinationAlgorithm
{
    static void Combinate(int[] numbers, int index, int current, int n)
    {
        if (index == numbers.Length)
        {
            Console.Write("{");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("}");
        }
        else
        {
            for (int i = current; i <= n; i++)
            {
                numbers[index] = i;
                Combinate(numbers, index + 1, i + 1, n);
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

        Combinate(numbers, 0, 1, n);
    }
}
