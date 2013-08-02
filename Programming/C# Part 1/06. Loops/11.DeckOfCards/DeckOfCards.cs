using System;

class DeckOfCards
{
    static void Main()
    {
        Console.WriteLine("This program will print all cards from a deck (without jokers)");
        string color = "";
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {      
                switch (j)
                {
                    case 1:
                        color = "Hearts";
                        break;
                    case 2:
                        color = "Clubs";
                        break;
                    case 3:
                        color = "Diamonds";
                        break;
                    case 4:
                        color = "Spades";
                        break;
                }

                switch (i)
                {
                    case 2:
                        Console.WriteLine("Two of " + color);
                        break;
                    case 3:
                        Console.WriteLine("Three of " + color);
                        break;
                    case 4:
                        Console.WriteLine("Four of " + color);
                        break;
                    case 5:
                        Console.WriteLine("Five of " + color);
                        break;
                    case 6:
                        Console.WriteLine("Six of " + color);
                        break;
                    case 7:
                        Console.WriteLine("Seven of " + color);
                        break;
                    case 8:
                        Console.WriteLine("Eight of " + color);
                        break;
                    case 9:
                        Console.WriteLine("Nine of " + color);
                        break;
                    case 10:
                        Console.WriteLine("Ten of " + color);
                        break;
                    case 11:
                        Console.WriteLine("Jack of " + color);
                        break;
                    case 12:
                        Console.WriteLine("Queen of " + color);
                        break;
                    case 13:
                        Console.WriteLine("King of " + color);
                        break;
                    case 14:
                        Console.WriteLine("Ace of " + color);
                        break;
                }
            }
        }
    }
}
