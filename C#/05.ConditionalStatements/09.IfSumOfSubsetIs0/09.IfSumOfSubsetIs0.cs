/* We are given 5 integer numbers. Write a program that checks if the sum
 * of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0. */

using System;

class IfSumOfSubsetIs0
{
    static void Main()
    {
        bool isValid;
        string inString;
        int[] var = new int[5];

        for (byte i = 0; i < 5; i++)
        {
            do
            {
                Console.Write("Please, enter integer number " + (i + 1) + " :");
                inString = Console.ReadLine();
                isValid = int.TryParse(inString, out var[i]) && var[i] >= int.MinValue && var[i] <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter valid number");
                    Console.WriteLine();
                }
            }
            while (!isValid);
        }

        if (var[0] + var[1] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[0], var[1]);
        }
        if (var[0] + var[2] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[0], var[2]);
        }
        if (var[0] + var[3] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[0], var[3]);
        }
        if (var[0] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[0], var[4]);
        }
        if (var[1] + var[2] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[1], var[2]);
        }
        if (var[1] + var[3] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[1], var[3]);
        }
        if (var[1] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[1], var[4]);
        }
        if (var[2] + var[3] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[2], var[3]);
        }
        if (var[2] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[2], var[4]);
        }
        if (var[3] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} = 0", var[3], var[4]);
        }
        if (var[0] + var[1] + var[2] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", var[0], var[1], var[2]);
        }
        if (var[0] + var[1] + var[3] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", var[0], var[1], var[3]);
        }
        if (var[0] + var[1] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", var[0], var[1], var[4]);
        }
        if (var[1] + var[2] + var[3] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", var[1], var[2], var[3]);
        }
        if (var[1] + var[2] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", var[1], var[2], var[4]);
        }
        if (var[2] + var[3] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", var[2], var[3], var[4]);
        }
        if (var[0] + var[1] + var[2] + var[3] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", var[0], var[1], var[2], var[3]);
        }
        if (var[0] + var[1] + var[2] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", var[0], var[1], var[2], var[4]);
        }
        if (var[0] + var[1] + var[3] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", var[0], var[1], var[3], var[4]);
        }
        if (var[0] + var[2] + var[3] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", var[0], var[2], var[3], var[4]);
        }
        if (var[1] + var[2] + var[3] + var[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", var[1], var[2], var[3], var[4]);
        }
    }
}