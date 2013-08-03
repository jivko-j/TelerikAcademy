/* We are given integer number n, value v (v=0 or 1) and a position p.
 * Write a sequence of operators that modifies n to hold the value v at the position p
 * from the binary representation of n. 
 * Example: n = 5 (00000101), p=3, v=1  13 (00001101)
 * n = 5 (00000101), p=2, v=0  1 (00000001) */

using System;

class ModifyBit
{
    static void Main()
    {
        // Variable's names is as given in the exercise, i'd prefer more descriptive names.
        int n;
        int v;
        byte p;
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

        do
        {
            Console.Write("Please, enter the value (0 or 1): ");
            string inNumberStr = Console.ReadLine();
            isValid = int.TryParse(inNumberStr, out v) && ((v == 0) || (v == 1));
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

        string nBinary = Convert.ToString(n, 2);
        Console.WriteLine();
        Console.WriteLine("Number {0} in binary is {1}", n, nBinary);
        Console.WriteLine("After changing bit {0} to {1}", p, v);

        if (v == 0)
        {
            // set bit p to 0
            int mask = ~(1 << p);
            n = n & mask;
        }
        else
        {
            // set bit p to 1
            int mask = 1 << p;
            n = n | mask;
        }

        nBinary = Convert.ToString(n, 2);
        Console.WriteLine("Result number is {0}, in binary {1}", n, nBinary);
    }
}