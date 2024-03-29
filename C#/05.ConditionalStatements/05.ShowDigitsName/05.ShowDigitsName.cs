﻿/* Write program that asks for a digit and depending on the input shows
 * the name of that digit (in English) using a switch statement. */

using System;

class ShowDigitsName
{
    static void Main()
    {
        bool isValid;
        string inString;
        byte digit;

        while (true)
        {
            do
            {
                Console.Write("Please, enter a digit (0-9) or [ctrl + C] for exit:");
                inString = Console.ReadLine();
                isValid = byte.TryParse(inString, out digit) && (digit < 10);
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter a digit");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            switch (digit)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
            }
        }
    }
}