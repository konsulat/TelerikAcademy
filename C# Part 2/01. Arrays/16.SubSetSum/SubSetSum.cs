using System;

class SubSetSum
{
    static void Main()
    {
        // Works only for positive integer arrays and sum
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int sum = 17;

        bool[] posibleSums = new bool[sum + 1];
        string[] indexArray = new string[sum + 1];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < posibleSums.Length)
            {
                posibleSums[numbers[i]] = true;
                indexArray[numbers[i]] = i.ToString();
            }

            for (int j = sum; j > 0; j--)
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

            if (posibleSums[sum] == true)
            {
                break;
            }
        }

        if (posibleSums[sum] == true)
        {
            Console.Write("Yes { ");
            string[] indexes = indexArray[sum].Split(',');
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
}