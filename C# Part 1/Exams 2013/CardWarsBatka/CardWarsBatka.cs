using System;
using System.Numerics;

class CardWarsBatka
{
    static void Main()
    {
        int numberOfAllGames = int.Parse(Console.ReadLine());
        const int cardsToPlayer = 3;
        BigInteger playerOneGlobalScore = 0;
        BigInteger playerTwoGlobalScore = 0;
        bool xCardDrownByPlayerOne = false;
        bool xCardDrownByPlayerTwo = false;
        int gamesWonByPlayerOne = 0;
        int gamesWonByPlayerTwo = 0;

        for (int i = 0; i < numberOfAllGames; i++)
        {
            int currentPlayerOneScore = 0;
            int currentPlayerTwoScore = 0;

            for (int j = 0; j < cardsToPlayer; j++)
            {
                string currentCard = Console.ReadLine();
                switch (currentCard)
                {
                    case "J": currentPlayerOneScore += 11; break;
                    case "Q": currentPlayerOneScore += 12; break;
                    case "K": currentPlayerOneScore += 13; break;
                    case "A": currentPlayerOneScore += 1; break;
                    case "Z": playerOneGlobalScore *= 2; break;
                    case "Y": playerOneGlobalScore -= 200; break;
                    case "X": xCardDrownByPlayerOne = true; break;
                    default: currentPlayerOneScore += 12 - int.Parse(currentCard); 
                        break;
                }
            }

            for (int j = 0; j < cardsToPlayer; j++)
            {
                string currentCard = Console.ReadLine();
                switch (currentCard)
                {
                    case "J": currentPlayerTwoScore += 11; break;
                    case "Q": currentPlayerTwoScore += 12; break;
                    case "K": currentPlayerTwoScore += 13; break;
                    case "A": currentPlayerTwoScore += 1; break;
                    case "Z": playerTwoGlobalScore *= 2; break;
                    case "Y": playerTwoGlobalScore -= 200; break;
                    case "X": xCardDrownByPlayerTwo = true; break;
                    default: currentPlayerTwoScore += 12 - int.Parse(currentCard);
                        break;
                }
            }

            if (xCardDrownByPlayerOne && xCardDrownByPlayerTwo)
            {
                playerOneGlobalScore += 50;
                playerTwoGlobalScore += 50;

                xCardDrownByPlayerOne = false;
                xCardDrownByPlayerTwo = false;
            }
            else if (xCardDrownByPlayerOne)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (xCardDrownByPlayerTwo)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }

            if (currentPlayerOneScore > currentPlayerTwoScore)
            {
                playerOneGlobalScore += currentPlayerOneScore;
                gamesWonByPlayerOne++;
            }
            else if (currentPlayerOneScore < currentPlayerTwoScore)
            {
                playerTwoGlobalScore += currentPlayerTwoScore;
                gamesWonByPlayerTwo++;
            }
        }

        if (playerOneGlobalScore > playerTwoGlobalScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", playerOneGlobalScore);
            Console.WriteLine("Games won: {0}", gamesWonByPlayerOne);
        }
        else if (playerOneGlobalScore < playerTwoGlobalScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", playerTwoGlobalScore);
            Console.WriteLine("Games won: {0}", gamesWonByPlayerTwo);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", playerOneGlobalScore);
        }
    }
}
