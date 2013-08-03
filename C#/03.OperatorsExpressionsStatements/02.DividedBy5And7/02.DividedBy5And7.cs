/* Write a boolean expression that checks for given integer if it can be divided
 * (without remainder) by 7 and 5 in the same time. */

using System;

class DividedBy5And7
{
    static void Main()
    {
        long inNumber;
        bool isValid;

        do
        {
            Console.Write("Please, enter an integer number: ");
            string inNumberStr = Console.ReadLine();
            isValid = long.TryParse(inNumberStr, out inNumber) && (inNumber >= long.MinValue) && (inNumber <= long.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        bool divided5and7 = inNumber % 5 == 0 && inNumber % 7 == 0;
        Console.WriteLine("Number " + inNumber + " can " + (divided5and7 ? "" : "not ") + "be divided by 5 and 7");
    }
}