/* Write a program that converts a number in the range [0...999] to a text
 * corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven" */

using System;

class ConvertNumberToText
{
    static void Main()
    {
        bool isValid;
        string inString;
        int number;

        while (true)
        {
            do
            {
                Console.Write("Please, enter an nuber [0..999], or [ctrl + C] for exit: ");
                inString = Console.ReadLine();
                isValid = int.TryParse(inString, out number) && number >= 0 && number < 1000;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct nuber [0..999]");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            string words = "";

            int ones = number % 10;
            int tens = number % 100 / 10;
            int hundreds = number % 1000 / 100;

            switch (hundreds)
            {
                case 1: words = "one hundred"; break;
                case 2: words = "two hundred"; break;
                case 3: words = "three hundred"; break;
                case 4: words = "four hundred"; break;
                case 5: words = "five hundred"; break;
                case 6: words = "six hundred"; break;
                case 7: words = "seven hundred"; break;
                case 8: words = "eight hundred"; break;
                case 9: words = "nine hundred"; break;
            }

            if (hundreds > 0 && (tens > 0 || ones > 0))
            {
                words = words + " and ";
            }

            switch (tens)
            {
                case 1:
                    {
                        switch (ones)
                        {
                            case 0: words = words + "ten"; break;
                            case 1: words = words + "eleven"; break;
                            case 2: words = words + "twelve"; break;
                            case 3: words = words + "thirteen"; break;
                            case 4: words = words + "fourteen"; break;
                            case 5: words = words + "fifteen"; break;
                            case 6: words = words + "sixteen"; break;
                            case 7: words = words + "seventeen"; break;
                            case 8: words = words + "eighteen"; break;
                            case 9: words = words + "nineteen"; break;
                        }
                        break;
                    }
                case 2: words = words + "twenty"; break;
                case 3: words = words + "thirty"; break;
                case 4: words = words + "forty"; break;
                case 5: words = words + "fifty"; break;
                case 6: words = words + "sixty"; break;
                case 7: words = words + "seventy"; break;
                case 8: words = words + "eighty"; break;
                case 9: words = words + "ninety"; break;
            }
            if (tens > 1 && ones > 0)
            {
                words = words + " ";
            }
            if (tens != 1)
            {
                switch (ones)
                {
                    case 1: words = words + "one"; break;
                    case 2: words = words + "two"; break;
                    case 3: words = words + "three"; break;
                    case 4: words = words + "four"; break;
                    case 5: words = words + "five"; break;
                    case 6: words = words + "six"; break;
                    case 7: words = words + "seven"; break;
                    case 8: words = words + "eight"; break;
                    case 9: words = words + "nine"; break;
                }
            }
            
            if (number == 0)
            {
                words = "zero";
            }

            Console.WriteLine("Number {0} spells {1}", number, words);
        }
    }
}