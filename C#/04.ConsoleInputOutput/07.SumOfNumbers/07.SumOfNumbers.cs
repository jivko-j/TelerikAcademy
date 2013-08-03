/* Write a program that gets a number n and after that gets more n numbers
 * and calculates and prints their sum. */

using System;

class SumOfNumbers
{
    static void Main()
    {
        bool isValid;
        string inString;
        uint n;
        double numberN;
        double sum = 0;

        do
        {
            Console.Write("Please, enter number of entries N = ");
            inString = Console.ReadLine();
            isValid = uint.TryParse(inString, out n) && (n > 0) && (n <= uint.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        for (uint i = 1; i <= n; i++)
        {
            do
            {
                Console.Write("Enter number  No " + i + " : ");
                inString = Console.ReadLine();
                isValid = double.TryParse(inString, out numberN) && (numberN >= double.MinValue) && (numberN <= double.MaxValue);
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            sum += numberN;
            Console.WriteLine("Sum of entered {0} numbers is {1}", i, sum);
        }
    }
}