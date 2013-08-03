// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class TrapezoidArea
{
    static void Main()
    {
        float sideA;
        float sideB;
        float height;
        bool isValid;

        do
        {
            Console.Write("Please, enter trapezoid's side A: ");
            string inNumberStr = Console.ReadLine();
            isValid = float.TryParse(inNumberStr, out sideA) && (sideA > 0) && (sideA <= float.MaxValue);
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
            Console.Write("Please, enter trapezoid's side B: ");
            string inNumberStr = Console.ReadLine();
            isValid = float.TryParse(inNumberStr, out sideB) && (sideB > 0) && (sideB <= float.MaxValue);
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
            Console.Write("Please, enter trapezoid's height: ");
            string inNumberStr = Console.ReadLine();
            isValid = float.TryParse(inNumberStr, out height) && (height > 0) && (height <= float.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        float area = (sideA + sideB) * height / 2;

        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}