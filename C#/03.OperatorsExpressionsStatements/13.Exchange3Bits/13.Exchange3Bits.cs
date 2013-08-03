/* Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26
 * of given 32-bit unsigned integer. */

using System;

class Exchange3Bits
{
    static void Main()
    {
        int n;
        int mask;
        int bitI1;
        int bitI2;
        bool isValid;

        do
        {
            Console.Write("Please, enter an integer number: ");
            string inNumberStr = Console.ReadLine();
            isValid = int.TryParse(inNumberStr, out n) && (n >= int.MinValue) && (n <= int.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);


        string nBinary = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.WriteLine();
        Console.WriteLine("Original number in binary {1}", n, nBinary);

        for (byte i = 3; i < 6; i++)
        {
            // Get value of bit i (3 to 5)
            mask = 1 << i;
            bitI1 = (n & mask) >> i;

            // Get value of bit i + 21 (24 to 26)
            mask = 1 << i + 21;
            bitI2 = (n & mask) >> i;

            // Set bit i with value of bit i + 21
            if (bitI2 == 0)
            {
                // set bit to 0
                mask = ~(1 << i);
                n = n & mask;
            }
            else
            {
                // set bit to 1
                mask = 1 << i;
                n = n | mask;
            }
            // Set bit i + 21 with value of bit i 
            if (bitI1 == 0)
            {
                // set bit to 0
                mask = ~(1 << i + 21);
                n = n & mask;
            }
            else
            {
                // set bit to 1
                mask = 1 << i + 21;
                n = n | mask;
            }
        }

        nBinary = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.WriteLine("Result number in binary   {0}", nBinary);
    }
}