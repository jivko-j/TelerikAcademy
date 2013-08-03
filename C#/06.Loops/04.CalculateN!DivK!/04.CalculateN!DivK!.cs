// Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class CalculateNFactDivKFact
    {
        static void Main()
        {
            ushort k;
            ushort n;
            bool isValid;

            do
            {
                Console.Write("Please, enter K (K > 1): ");
                isValid = ushort.TryParse(Console.ReadLine(), out k)
                    && k > 1 && k <= ushort.MaxValue;
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
                Console.Write("Please, enter N (N > K): ");
                isValid = ushort.TryParse(Console.ReadLine(), out n)
                    && n > k && n <= ushort.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            BigInteger result = 1;

            for (int i = n ; i > k; i--)
            {
                result *= i;
            }
            Console.WriteLine("N!/K! = {0}", result);
        }
    }