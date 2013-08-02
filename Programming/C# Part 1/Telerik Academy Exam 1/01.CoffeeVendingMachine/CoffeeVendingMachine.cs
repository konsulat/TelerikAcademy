using System;

class CoffeeVendingMachine
{
    static void Main()
    {
        int[] numberOfCoins = new int[5];

        for (int i = 0; i < 5; i++)
        {
            numberOfCoins[i] = int.Parse(Console.ReadLine());
        }
        decimal amount = decimal.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());

        decimal amountInMachine = 0.05M * numberOfCoins[0] + 0.10M * numberOfCoins[1] +
            0.20M * numberOfCoins[2] + 0.50M * numberOfCoins[3] + 1.00M * numberOfCoins[4];
        if (price > amount)
        {
            decimal moreMoney = price - amount;
            Console.WriteLine("More  {0:0.00}", moreMoney);
        }
        else
        {
            decimal changeToGive = amount - price;

            decimal changeInMachine = amountInMachine - changeToGive;

            
            if (changeInMachine < 0.00M)
            {
                Console.WriteLine("No {0:0.00}", -changeInMachine);
            }
            else
            {
                Console.WriteLine("Yes {0:0.00}", changeInMachine);
            }
        }
    }
}
