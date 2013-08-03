// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class CalculateNFactxKFactDivK_NFact
{
    static void Main()
    {
        ushort k;
        ushort n;
        bool isValid;

        do
        {
            Console.Write("Please, enter N (N > 1): ");
            isValid = ushort.TryParse(Console.ReadLine(), out n)
                && n > 1 && n <= ushort.MaxValue;
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
            Console.Write("Please, enter K (K > N): ");
            isValid = ushort.TryParse(Console.ReadLine(), out k)
                && k > n && k <= ushort.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        BigInteger result = 1;

        // N!*K! / (K-N)!  =  N! * ( K!/(K-N)!)

        // N!
        for (int i = n; i > 1; i--)
        {
            result *= i;
        }

        //  K!/(K-N)! - Loop from K to K-N
        for (int i = k; i > k - n; i--)
        {
            result *= i;
        }
        Console.WriteLine("N!*K!/(K-N)! = {0}", result);
    }
}