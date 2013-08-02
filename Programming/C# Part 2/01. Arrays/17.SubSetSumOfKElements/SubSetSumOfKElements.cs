using System;

class SubSetSumOfKElements
{
    static void Main()
    {
        Console.Write("Enter number N (positive integer): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K (K <= N, positive integer): ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter number S (sum, positive integer): ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an array of positive integers of N elements");
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool[] posibleSums = new bool[s + 1];
        string[] indexArray = new string[s + 1];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < posibleSums.Length)
            {
                posibleSums[numbers[i]] = true;
                indexArray[numbers[i]] = i.ToString();
            }

            for (int j = s; j > 0; j--)
            {
                if (posibleSums[j] == true && j != numbers[i])
                {
                    if (numbers[i] + j < posibleSums.Length)
                    {
                        posibleSums[numbers[i] + j] = true;
                        if (indexArray[j] != i.ToString())
                        {
                            indexArray[numbers[i] + j] = indexArray[j];
                        }
                        indexArray[numbers[i] + j] = indexArray[numbers[i] + j] + "," + i.ToString();
                    }
                }
            }
 
            if (posibleSums[s] == true)
            {
                string[] indexes = indexArray[s].Split(',');
                if (indexes.Length == k)
                {
                    break;
                }
            }
        }


        if (posibleSums[s] == true)
        {
            string[] indexes = indexArray[s].Split(',');
            if (indexes.Length == k)
            {
                Console.Write("Yes { ");
                for (int i = 0; i < indexes.Length; i++)
                {
                    int index = int.Parse(indexes[i]);
                    Console.Write(numbers[index] + " ");
                }
                Console.WriteLine("}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
