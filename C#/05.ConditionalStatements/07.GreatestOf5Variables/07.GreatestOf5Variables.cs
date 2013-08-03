// Write a program that finds the greatest of given 5 variables.

using System;

class PGreatestOf5Variables
{
    static void Main()
    {
        bool isValid;
        string inString;
        float inNumber;
        float greatest = float.MinValue;

        for (byte i = 1; i < 6; i++)
        {
            do
            {
                Console.Write("Please, enter variable No {0}:", i);
                inString = Console.ReadLine();
                isValid = float.TryParse(inString, out inNumber) && (inNumber >= float.MinValue) && (inNumber <= float.MaxValue);
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            if (inNumber > greatest)
            {
                greatest = inNumber;
            }
        }
        Console.WriteLine("The greatest of entered 5 variables is {0}", greatest);
    }
}
