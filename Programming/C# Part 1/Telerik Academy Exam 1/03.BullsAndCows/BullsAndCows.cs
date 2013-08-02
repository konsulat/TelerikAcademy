using System;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();
        int buls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int[] currentNumber = new int[4];
        for (int i = 0; i < 4; i++)
        {
            currentNumber[i] = secretNumber[i];
        }

    }
}
