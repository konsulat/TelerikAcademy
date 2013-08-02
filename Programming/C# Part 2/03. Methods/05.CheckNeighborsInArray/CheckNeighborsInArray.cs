using System;

class CheckNeighborsInArray
{
    static bool IsBigger(int[] numbers, int position)
    {
        if (numbers.Length == 1)
        {
            return true;
        }

        if (position > numbers.Length - 1)
        {
            return false;
        }

        if (position == 0)
        {
            if (numbers[position] > numbers[position + 1])
            {
                return true;
            }
        }
        else if (position == numbers.Length - 1)
        {
            if (numbers[position] > numbers[position - 1])
            {
                return true;
            }
        }
        else
        {
            if (numbers[position] > numbers[position + 1] && numbers[position] > numbers[position - 1])
            {
                return true;
            }
        }
        return false;
    }
     
    static void Main()
    {
        int[] numbers = { 5, 7, 4, 5, 3, 6, 10, 5 };
        int position = 1;

        if (IsBigger(numbers, position))
        {
            Console.WriteLine("The number at position {0} is bigger than its neighbor/s", position);
        }
        else
        {
            Console.WriteLine("The number at position {0} is NOT bigger than its neighbor/s", position);
        }
    }
}
