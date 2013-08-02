using System;

class PermutationAlgorithm
{
    static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }

    static void Permute(int[] numbers, int current, int length)
    {
        if (current == length)
        {
            Console.Write("{");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("}");
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Swap(ref numbers[i], ref numbers[current]);
                Permute(numbers, current + 1, length);
                Swap(ref numbers[i], ref numbers[current]);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }
        
        Permute(numbers, 0, numbers.Length - 1);
    }
}
