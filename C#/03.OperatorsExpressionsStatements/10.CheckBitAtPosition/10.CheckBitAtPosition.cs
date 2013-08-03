/* Write a boolean expression that returns if the bit at position p (counting from 0)
 * in a given integer number v has value of 1. Example: v=5; p=1  false. */

using System;
class CheckBitAtPosition
{
    static void Main()
    {
        // Variable's names is as given in the exercise, i'd prefer more descriptive names.
        int v;
        byte p;
        bool isValid;

        do
        {
            Console.Write("Please, enter an integer number: ");
            string inNumberStr = Console.ReadLine();
            isValid = int.TryParse(inNumberStr, out v) && (v >= int.MinValue) && (v <= int.MaxValue);
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
            isValid = byte.TryParse(inNumberStr, out p) && (p < 32);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);
        
        int mask = 1 << p; 
        bool bitIs1 = (v & mask) != 0;

        Console.WriteLine("v = {0}; p = {1} -> {2}", v, p, bitIs1);
    }
}
