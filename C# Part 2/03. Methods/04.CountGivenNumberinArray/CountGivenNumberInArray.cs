using System;

namespace ForTests
{
    public class CountGivenNumberInArray
    {
        public static int CountGivenNumber(int number, int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (number == numbers[i])
                {
                    count++;
                }
            }
            return count;
        }

        static void Main()
        {
            Console.Write("Enter the number which appearance you want to check: ");
            int num = int.Parse(Console.ReadLine());
            int[] numArray = { 1, 3, 5, 1, 4, 3, 5, 6, 7, 8, 10, 9, 5, 5, 6, 3, 2 };
            Console.WriteLine("Your number ({0}) appears {1} time/s in given array",
                num, CountGivenNumber(num, numArray));
        }
    }
}
