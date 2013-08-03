/* Write a program that reads from the console a sequence of N integer numbers
 * and returns the minimal and maximal of them. */

using System;

class ReturnMinAndMaxNumber
{
    static void Main()
    {
        uint n;
        int number;
        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;
        bool isValid;

        do
        {
            Console.Write("Please, enter nubmer of integer numbers: ");
            isValid = uint.TryParse(Console.ReadLine(), out n)
                && n > 1 && n <= uint.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        for (int i = 1; i <= n; i++)
        {
            do
            {
                Console.Write("Enter number " + i + ": ");
                isValid = int.TryParse(Console.ReadLine(), out number)
                    && number >= int.MinValue && number <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            if (number < minNumber)
            {
                minNumber = number;
            }
            else if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("The minimal number is {0}", minNumber);
        Console.WriteLine("The maximal number is {0}", maxNumber);
    }
}