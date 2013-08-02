using System;
using System.Collections.Generic;

class BullsAndCows
{
    static void Main()
    {
        string secretNum = Console.ReadLine();
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());
        char usedSecretNum = '*';
        char usedGuessNum = '@';
        List<int> results = new List<int>();

        for (int num = 1000; num <= 9999; num++)
        {
            int countFoundBulls = 0;
            int countFoundCows = 0;
            char[] digitsGuess = num.ToString().ToCharArray();
            char[] secretNumDigits = secretNum.ToCharArray();

            if (digitsGuess[0] >= '1' && digitsGuess[1] >= '1' && digitsGuess[2] >= '1' && digitsGuess[3] >= '1')
            {
                for (int i = 0; i < digitsGuess.Length; i++)
                {
                    if (secretNumDigits[i] == digitsGuess[i])
                    {
                        countFoundBulls++;
                        digitsGuess[i] = usedGuessNum;
                        secretNumDigits[i] = usedSecretNum;
                    }
                }

                for (int i = 0; i < digitsGuess.Length; i++)
                {
                    for (int j = 0; j < secretNumDigits.Length; j++)
                    {
                        if (secretNumDigits[i] == digitsGuess[j])
                        {
                            countFoundCows++;
                            digitsGuess[j] = usedGuessNum;
                            secretNumDigits[i] = usedSecretNum;
                        }
                    }
                    
                }

                if (countFoundCows == targetCows && countFoundBulls == targetBulls)
	            {
                    results.Add(num);
	            }
            }
        }

        if (results.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = 0; i < results.Count; i++)
            {
                Console.Write(results[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
