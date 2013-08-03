// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class Read3Numbers
{
    static void Main()
    {
        bool isValid;
        string inString;
        int numberA;
        int numberB;
        int numberC;

        do
        {
            Console.Write("Please, enter number A: ");
            inString = Console.ReadLine();
            isValid = int.TryParse(inString, out numberA) && (numberA >= int.MinValue) && (numberA <= int.MaxValue);
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
            Console.Write("Please, enter number B: ");
            inString = Console.ReadLine();
            isValid = int.TryParse(inString, out numberB) && (numberB >= int.MinValue) && (numberB <= int.MaxValue);
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
            Console.Write("Please, enter number C: ");
            inString = Console.ReadLine();
            isValid = int.TryParse(inString, out numberC) && (numberC >= int.MinValue) && (numberC <= int.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        Console.WriteLine("Sum of the numbers is " + (numberA + numberB + numberC));
    }
}