// Write a program that, for a given two integer numbers N and X, 
// calculates the sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;
using System.Numerics;

class SumOfFactorielDivPower
{
    static void Main()
    {
        ushort n;
        int x;
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
            Console.Write("Please, enter X (X != 0): ");
            isValid = int.TryParse(Console.ReadLine(), out x)
                && x != 0 && x >= int.MinValue && x <= int.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        decimal sum = 1;
        decimal factoriel = 1;
        decimal power = 1;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            power *= x;
            sum += factoriel / power;
        }

        Console.WriteLine("sum S = 1 + ... + N!/X^N = {0}", sum);
    }
}