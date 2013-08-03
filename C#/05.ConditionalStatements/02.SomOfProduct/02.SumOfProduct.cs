/* Write a program that shows the sign (+ or -) of the product of three real numbers
 * without calculating it. Use a sequence of if statements. */

using System;

class SumOfProduct
{
    static void Main()
    {
        bool isValid;
        string inString;
        float a;
        float b;
        float c;
        bool negativeSign;

        do
        {
            Console.Write("Please, enter first  number:");
            inString = Console.ReadLine();
            isValid = float.TryParse(inString, out a) && (a >= float.MinValue) && (a <= float.MaxValue);
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
            Console.Write("Please, enter second number:");
            inString = Console.ReadLine();
            isValid = float.TryParse(inString, out b) && (b >= float.MinValue) && (b <= float.MaxValue);
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
            Console.Write("Please, enter third  number:");
            inString = Console.ReadLine();
            isValid = float.TryParse(inString, out c) && (c >= float.MinValue) && (c <= float.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product of three numbers is 0");
            return;
        }

        // It's far easily without this if statement, but that's the requirement.
 
        if (a < 0 ^ b < 0 ^ c < 0)
        {
            negativeSign = true;
        }
        else
        {
            negativeSign = false;
        }

        Console.WriteLine("The sign of the product of three numbers is \"{0}\"", negativeSign ? "-" : "+");
    }
}