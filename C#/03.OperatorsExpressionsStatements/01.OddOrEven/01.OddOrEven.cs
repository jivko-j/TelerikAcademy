// Write an expression that checks if given integer is odd or even.

using System;
class OddOrEven
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

        bool isEven = inNumber % 2 == 0;
        Console.WriteLine("Number " + inNumber + " is " + (isEven ? "even" : "odd"));

    }
}