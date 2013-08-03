// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IfNumberIsPrime
{
    static void Main()
    {
        byte inNumber;
        bool isValid;

        do
        {
            Console.Write("Please, enter integer number between 1 and 100: ");
            string inNumberStr = Console.ReadLine();
            isValid = byte.TryParse(inNumberStr, out inNumber) && (inNumber <= 100);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number!");
                Console.WriteLine();
            }
        }
        while (!isValid);

        // Check if the number is one of the prime numbers to square root of tne number (max 100)
        // or the number can't be devided to one of these prime numbers.

        bool isPrime = (inNumber == 2 || inNumber == 3 || inNumber == 5 || inNumber == 7) ||
            (inNumber % 2 > 0 && inNumber % 3 > 0 && inNumber % 5 > 0 && inNumber % 7 > 0);

        Console.WriteLine("Number {0} is prime -> {1}", inNumber, isPrime);
    }
}