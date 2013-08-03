/* Write a program that reads two positive integer numbers and prints how many numbers p
 * exist between them such that the reminder of the division by 5 is 0 (inclusive).
 * Example: p(17,25) = 2. */

using System;

class NumbersDividedBy5
{
    static void Main()
    {
        bool isValid;
        string inString;
        uint number1;
        uint number2;
        uint counter;

        do
        {
            Console.Write("Please, enter first number: ");
            inString = Console.ReadLine();
            isValid = uint.TryParse(inString, out number1) && (number1 > 0) && (number1 <= uint.MaxValue);
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
            Console.Write("Please, enter second number: ");
            inString = Console.ReadLine();
            isValid = uint.TryParse(inString, out number2) && (number2 > 0) && (number2 <= uint.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);


        // Exchange numbers if number1 is greater than number2
        if (number1 > number2)
        {
            uint tmp = number1;
            number1 = number2;
            number2 = tmp;
        }

        if (number1 % 5 == 0)
        {
            counter = ((number2 - number1) / 5) + 1;
        }
        else
        {
            uint firstDiv5 = ((number1 / 5) + 1) * 5;
            counter = ((number2 - firstDiv5) / 5) + 1;
        }

        Console.WriteLine("p({0} , {1}) = {2}", number1, number2, counter);
    }
}