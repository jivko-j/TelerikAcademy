// Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestOfThreeIntegers
    {
        static void Main()
        {
            bool isValid;
            string inString;
            int a;
            int b;
            int c;

            do
            {
                Console.Write("Please, enter first  number:");
                inString = Console.ReadLine();
                isValid = int.TryParse(inString, out a) && (a >= int.MinValue) && (a <= int.MaxValue);
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
                isValid = int.TryParse(inString, out b) && (b >= int.MinValue) && (b <= int.MaxValue);
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
                isValid = int.TryParse(inString, out c) && (c >= int.MinValue) && (c <= int.MaxValue);
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is {0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The biggest number is {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", c);
            }
        }
    }