//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class DisplaySeries
{
    static void Main()
    {
        for (byte i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0,4}", i);
            }
            else
            {
                Console.WriteLine("{0,4}", -i);
            }
        }

    }
}