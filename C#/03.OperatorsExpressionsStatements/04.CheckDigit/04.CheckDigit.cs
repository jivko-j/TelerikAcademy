// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class CheckDigit
{
    static void Main()
    {
        long inNumber;
        bool isValid;

        do
        {
            Console.Write("Please, enter an integer number: ");
            string inNumberStr = Console.ReadLine();
            isValid = long.TryParse(inNumberStr, out inNumber) && (inNumber >= 0) && (inNumber <= long.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        // By dividing the number by 100 third digit becomes last digit.
        // The remainder of dividing of the result by 10 is last digit (the digit we have to check).
        bool thirdDigitIs7 = (inNumber / 100) % 10 == 7;
      
        Console.WriteLine("Third digit of number " + inNumber + " is 7? -> " + thirdDigitIs7);
    }
}