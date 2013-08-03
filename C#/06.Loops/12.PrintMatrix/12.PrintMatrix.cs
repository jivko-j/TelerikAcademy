// Write a program that reads from the console a positive integer number N (N < 20)
// and outputs a matrix like the following:

using System;

class PrintMatrix
    {
        static void Main()
        {
            byte n;
            bool isValid;

            do
            {
                Console.Write("Please, enter N (0 < N < 20): ");
                isValid = byte.TryParse(Console.ReadLine(), out n)
                    && n > 0 && n < 20;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            for (int col = 1; col <= n; col++)
            {
                for (int row = col; row < n + col; row++)
                {
                    Console.Write("{0,3}",row);
                }
                Console.WriteLine();
            }
        }
    }