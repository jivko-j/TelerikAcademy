/* Write an expression that extracts from a given integer i the value of
 * a given bit number b. Example: i=5; b=2  value=1. */

using System;

class ExtractValueOfBit
{
    static void Main()
    {
        // Variable's names is as given in the exercise, i'd prefer more descriptive names.
        int i;
        byte b;
        bool isValid;

        do
        {
            Console.Write("Please, enter an integer number: ");
            string inNumberStr = Console.ReadLine();
            isValid = int.TryParse(inNumberStr, out i) && (i >= int.MinValue) && (i <= int.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        do
        {
            Console.Write("Please, enter the position (0-31): ");
            string inNumberStr = Console.ReadLine();
            isValid = byte.TryParse(inNumberStr, out b) && (b < 32);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        int mask = 1 << b;
        int bitB = (i & mask) >> b;

        Console.WriteLine("i = {0}; b = {1} -> {2}", i, b, bitB);
    }
}
