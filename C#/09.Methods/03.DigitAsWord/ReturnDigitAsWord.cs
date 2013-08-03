/* Write a method that returns the last digit of given integer as an English word.
 * Examples: 512  "two", 1024  "four", 12309  "nine". */

using System;

class ReturnDigitAsWord
    {
        static void Main()
        {
            int number = InputNumber("Please, enter an integer: ", int.MinValue, int.MaxValue);
            Console.WriteLine("Last digit of the number is '{0}'",LastDigitAsWord(number));
        }

        static int InputNumber(string message, int min, int max)
        {
            bool isValid;
            int output;
            do
            {
                Console.Write(message);
                isValid = int.TryParse(Console.ReadLine(), out output) && output >= min && output <= max;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            } while (!isValid);
            return output;
        }

        static string LastDigitAsWord(int number)
        {
            int lastDigit = number % 10;
            string digitAsWord = "";

            switch (lastDigit)
            {
                case 0: digitAsWord = "zero"; break;
                case 1: digitAsWord = "one"; break;
                case 2: digitAsWord = "two"; break;
                case 3: digitAsWord = "three"; break;
                case 4: digitAsWord = "four"; break;
                case 5: digitAsWord = "five"; break;
                case 6: digitAsWord = "six"; break;
                case 7: digitAsWord = "seven"; break;
                case 8: digitAsWord = "eight"; break;
                case 9: digitAsWord = "nine"; break;
            }
            return digitAsWord;
        }
    }