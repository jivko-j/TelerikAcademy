// Sort 3 real values in descending order using nested if statements.

using System;

class Sort3RealValues
{
    static void Main()
    {
        bool isValid;
        string inString;
        float a;
        float b;
        float c;
        float temp;

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

        if (c > b)
        {
            if (c > a)
            {
                if (b > a)
                {
                    // order is c > b > a
                    temp = a;
                    a = c;
                    c = temp;
                }
                else
                {
                    // order is c > a > b
                    temp = a;
                    a = c;
                    c = b;
                    b = temp;
                }
            }
            else
            {
                // order is a > c > b
                temp = b;
                b = c;
                c = temp;
            }
        }
        else
        {
            if (b > a)
            {
                if (c > a)
                {
                    // order is b > c > a
                    temp = a;
                    a = b;
                    b = c;
                    c = temp;
                }
                else
                {
                    // order is b > a > c
                    temp = a;
                    a = b;
                    b = temp;
                }
            }
            // order is a > b > c
        }
        
        Console.WriteLine("Sorted order is {0}, {1}, {2}", a, b, c);
        }
}