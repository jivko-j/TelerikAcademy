/* Write a program that calculates the greatest common divisor (GCD) of given two numbers.
 * Use the Euclidean algorithm (find it in Internet). */

/* Euclid's algorithm starts with a pair of positive integers and forms a new pair
 * that consists of the smaller number and the difference between the larger and smaller
 * numbers. The process repeats until the numbers are equal.
 * That number then is the greatest common divisor of the original pair. */

using System;

class GreatestCommonDivisorOf2Numbers
{
    static void Main()
    {
        int a;
        int b;
        bool isValid;

        do
        {
            Console.Write("Please, enter A (A > 0): ");
            isValid = int.TryParse(Console.ReadLine(), out a)
                && a > 0 && a <= int.MaxValue;
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
            Console.Write("Please, enter B (B > 0): ");
            isValid = int.TryParse(Console.ReadLine(), out b)
                && b > 0 && b <= int.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        Console.WriteLine("The greatest common divisor is {0}", a);
    }
}