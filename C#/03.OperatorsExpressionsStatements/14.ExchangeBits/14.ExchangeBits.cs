/* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1}
 * of given 32-bit unsigned integer. */

using System;
class Exchange3Bits
{
    static void Main()
    {
        // Variable's names is as given in the exercise, i'd prefer more descriptive names.
        uint n;
        byte p;
        byte q;
        byte k;
        bool isValid;
        bool validRange;
        uint mask;
        uint bitPI;
        uint bitQI;

        do
        {
            Console.Write("Please, enter an positive integer number: ");
            string inNumberStr = Console.ReadLine();
            isValid = uint.TryParse(inNumberStr, out n) && (n >= 0) && (n <= uint.MaxValue);
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
            do
            {
                Console.Write("Please, enter start bit p (0-31): ");
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

            do
            {
                Console.Write("Please, enter start bit q (0-31): ");
                string inNumberStr = Console.ReadLine();
                isValid = byte.TryParse(inNumberStr, out q) && (q < 32);
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
                Console.Write("Please, enter number of bits k (1-16): ");
                string inNumberStr = Console.ReadLine();
                isValid = byte.TryParse(inNumberStr, out k) && (k > 0) && (k < 17);
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            }
            while (!isValid);


            // Ensure p < q
            if (p > q)
            {
                byte tmp = p;
                p = q;
                q = tmp;
            }

            validRange = (p + k - 1 < q) && (q + k - 1 < 32);
            if (!validRange)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid range!");
                Console.WriteLine("Make sure than p + k - 1 < q and q + k - 1 < 32");
                Console.WriteLine();

            }

        }
        while (!validRange);

        string nBinary = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.WriteLine();
        Console.WriteLine("Original number in binary {1}", n, nBinary);

        for (byte i = p; i < p + k; i++)
        {
            // Get value of bit p
            mask = 1u << i;
            bitPI = (n & mask) >> i;

            // Get value of bit q
            mask = 1u << i + q - p;
            bitQI = (n & mask) >> i;

            // Set bit p with value of bit q
            if (bitQI == 0)
            {
                // set bit to 0
                mask = ~(1u << i);
                n = n & mask;
            }
            else
            {
                // set bit to 1
                mask = 1u << i;
                n = n | mask;
            }
            // Set bit q with value of bit p
            if (bitPI == 0)
            {
                // set bit to 0
                mask = ~(1u << i + q - p);
                n = n & mask;
            }
            else
            {
                // set bit to 1
                mask = 1u << i + q - p;
                n = n | mask;
            }
        }
        nBinary = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.WriteLine("Result number in binary   {0}", nBinary);

    }
}