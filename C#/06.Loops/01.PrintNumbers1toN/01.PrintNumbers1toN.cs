// Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbers1toN
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
            Console.WriteLine(i);
        }
    }
}