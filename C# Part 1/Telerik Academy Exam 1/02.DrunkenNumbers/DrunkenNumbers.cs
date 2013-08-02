using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] roundScores = new int[n];
        for (int i = 0; i < n; i++)
        {
            roundScores[i] = int.Parse(Console.ReadLine());
        }

        int scoreMitko = 0;
        int scoreVladko = 0;
        int countMitko = 0;
        int countVladko = 0;
        int half = 0;
        for (int i = 0; i < n; i++)
        {
            half = roundScores[i].ToString().Length / 2;
            if (roundScores[i].ToString().Length % 2 == 0)
            {
                scoreMitko = roundScores[i] / (int)Math.Pow(10, half);
                scoreVladko = roundScores[i] % (int)Math.Pow(10, half);
                while (scoreMitko != 0)
                {
                    countMitko += scoreMitko % 10;
                    scoreMitko /= 10;
                }
                while (scoreVladko != 0)
                {
                    countVladko += scoreVladko % 10;
                    scoreVladko /= 10;
                }
            }
            else
            {
                scoreMitko = roundScores[i] / (int)Math.Pow(10, half);
                scoreVladko = roundScores[i] % (int)Math.Pow(10, half + 1);
                while (scoreMitko != 0)
                {
                    countMitko += scoreMitko % 10;
                    scoreMitko /= 10;
                }
                while (scoreVladko != 0)
                {
                    countVladko += scoreVladko % 10;
                    scoreVladko /= 10;
                }
            }
        }

        if (countMitko > countVladko)
        {
            Console.WriteLine("M {0}", countMitko - countVladko);
        }
        else if (countVladko > countMitko)
        {
            Console.WriteLine("V {0}", countVladko - countMitko);
        }
        else
        {
            Console.WriteLine("No {0}", countMitko + countVladko);
        }
    }
}
