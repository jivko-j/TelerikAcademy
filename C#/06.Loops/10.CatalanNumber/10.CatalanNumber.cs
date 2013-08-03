// Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;
 
class CatalanNumber
    {
        static void Main()
        {
            ushort n;
            bool isValid;

            do
            {
                Console.Write("Please, enter N (N > 0): ");
                isValid = ushort.TryParse(Console.ReadLine(), out n)
                    && n > 0 && n <= ushort.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            // First element is 1.
            // After some mathematical transformations I found that every next is:
            // C[i] = (C[i-1] * 2 * (2 * i - 1)) / (i + 1)

            BigInteger ci = 1;

            for (int i = 2; i <= n; i++)
            {
                ci = (ci * 2 * (2 * i - 1)) / (i + 1);
            }
            
            Console.WriteLine("Cn = {0}", ci);
        }
    }