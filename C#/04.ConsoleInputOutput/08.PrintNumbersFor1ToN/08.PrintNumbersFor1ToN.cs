/* Write a program that reads an integer number n from the console
 * and prints all the numbers in the interval [1..n], each on a single line. */

using System;

class PrintNumbersFor1ToN
{
    static void Main()
    {
        bool isValid;
        string inString;
        uint n;

        do
        {
            Console.Write("Please, enter N: ");
            inString = Console.ReadLine();
            isValid = uint.TryParse(inString, out n) && (n > 0) && n <= (uint.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correvt number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        for (uint i = 1; i <= n; i++)
        {
            Console.WriteLine("{0,10}", i);
        }
    }
}