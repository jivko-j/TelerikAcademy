/* Write a program that reads a number N and calculates the sum of the first N members
 * of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … */


using System;
using System.Numerics;

class SumOfFibonacci
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

        BigInteger sum;

        switch (n)
        {
            case 1: sum = 0; break;
            case 2: sum = 1; break;
            default:
                {
                    BigInteger memberA = 0;
                    BigInteger memberB = 1;
                    BigInteger newMember;
                    sum = 1;
                    for (ushort i = 3; i <= n; i++)
                    {
                        newMember = memberA + memberB;
                        memberA = memberB;
                        memberB = newMember;
                        sum += newMember;
                    }
                    break;
                }
        }

        Console.WriteLine("Sum of first {0} members is {1}", n, sum);
    }
}