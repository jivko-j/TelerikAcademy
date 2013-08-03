/* Write a program that applies bonus scores to given scores in the range [1..9].
 * The program reads a digit as an input. If the digit is between 1 and 3,
 * the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100;
 * if it is between 7 and 9, multiplies it by 1000.
 * If it is zero or if the value is not a digit, the program must report an error.
 * Use a switch statement and at the end print the calculated new value in the console. */

using System;

class ApplyBonusScores
{
    static void Main()
    {
        bool isValid;
        string inString;
        int score;

        do
        {
            Console.Write("Please, enter the score [1..9]:");
            inString = Console.ReadLine();
            isValid = int.TryParse(inString, out score) && score > 0 && score < 10;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct score [1..9]");
                Console.WriteLine();
            }
        }
        while (!isValid);

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                {
                    score *= 10; break;
                }
            case 4:
            case 5:
            case 6:
                {
                    score *= 100; break;
                }
            case 7:
            case 8:
            case 9:
                {
                    score *= 1000; break;
                }
        }
        Console.WriteLine("New score is {0}", score);
    }
}