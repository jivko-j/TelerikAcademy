// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class CheckBit
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

        long mask = 1 << 3;
        bool bit3is1 = (inNumber & mask) != 0 ;
        
        Console.WriteLine("bit 3 of number " + inNumber + " is 1? -> " + bit3is1);
    }
}