// Write a program that prints all the numbers from 1 to N,
// that are not divisible by 3 and 7 at the same time.


using System;

class PrintNumbers1toNnotDivisibleBy3and7
{
    static void Main()
    {
        uint n;
        bool isValid;

        do
        {
            Console.Write("Please, enter N: ");
            isValid = uint.TryParse(Console.ReadLine(), out n)
                && n > 0 && n <= uint.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        for (int i = 1; i <= n; i++)
        {
            if (!((i % 3 == 0) && (i % 7 == 0)))
            {
                Console.WriteLine(i);
            }
        }

    }
}