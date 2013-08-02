using System;

class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[11];
        for (int i = 10; i >= 0; i--)
        {
            a[i] = 1 << i;
        }

        if (n == 0)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("A");
                Console.WriteLine(i);
            }
        }
        else
        {
            int maxSubsets = (1 << 11) - 1;
            int[] index = new int[11];
            for (int i = 1; i < maxSubsets; i++)
            {
                int sum = 0;
                for (int j = 0; j < 11; j++)
                {
                    int mask = 1 << j;
                    int numberAndMak = i & mask;
                    int bit = numberAndMak >> j;
                    if (bit == 1)
                    {
                        sum += a[j];
                        index[10 - j] = 1;
                    }
                }       
                if (sum == n)
                {
                    break;
                }
                for (int j = 0; j < 11; j++)
                {
                    index[j] = 0;
                }
            }

            for (int i = 0; i < 11; i++)
            {
                if (index[i] == 0)
                {
                    Console.Write("A");
                    Console.WriteLine(i);
                }
            }
        }
    }
}
