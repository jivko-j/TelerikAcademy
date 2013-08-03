/* Write a program that finds all prime numbers in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia). */

using System;

class FindPrimeNumbers
{
    static void Main()
    {
        int length = 10000000;
        
        // Human counts from 1
        length++;
        bool[] isPrime = new bool[length];

        // Initialise array
        for (int i = 0; i < length; i++)
        {
            isPrime[i] = true;
        }

        // All dividers are to square root of the number
        int lengthSqrt = (int)Math.Sqrt(length);

        for (int i = 2; i < lengthSqrt; i++)
        {
            if (isPrime[i])
            {
                for (int p = 2; i * p < length; p++)
                {
                    isPrime[i * p] = false;
                }
            }
        }

        // Printing all prime numbers will take tooo long. Let count them.
        int counter = 0;
        for (int i = 2; i < length; i++)
        {
            if (isPrime[i])
            {
                counter++;
            }
        }

        Console.WriteLine("There are {0:N0} prime numbers from 2 to {1:N0}", counter, length);
    }
}