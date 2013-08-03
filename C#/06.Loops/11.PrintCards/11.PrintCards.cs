/* Write a program that prints all possible cards from a standard deck of 52 cards
 * (without jokers). The cards should be printed with their English names.
 * Use nested for loops and switch-case. */

using System;

class PrintCards
    {
        static void Main()
        {
            string type;
            string suit = "";

            for (int i = 2; i < 15; i++)
            {
                switch (i)
                {
                    case 2: type = "Two"; break;
                    case 3: type = "Three"; break;
                    case 4: type = "Four"; break;
                    case 5: type = "Five"; break;
                    case 6: type = "Six"; break;
                    case 7: type = "Seven"; break;
                    case 8: type = "Eight"; break;
                    case 9: type = "Nine"; break;
                    case 10: type = "Ten"; break;
                    case 11: type = "Jack"; break;
                    case 12: type = "Queen"; break;
                    case 13: type = "King"; break;
                    case 14: type = "Ace"; break;
                    default: type = i.ToString(); break;
                }

                for (int j = 1; j < 5; j++)
                {
                    switch (j)
                    {
                        case 1: suit = "clubs"; break;
                        case 2: suit = "diamonds"; break;
                        case 3: suit = "hearts"; break;
                        case 4: suit = "spades"; break;
                    }

                    Console.WriteLine("{0} of {1}", type, suit);
                }
            }
        }
    }