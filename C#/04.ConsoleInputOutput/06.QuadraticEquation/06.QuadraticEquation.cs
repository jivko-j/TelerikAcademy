/* Write a program that reads the coefficients a, b and c
 * of a quadratic equation ax2+bx+c=0 and solves it
 * (prints its real roots). */

using System;

class QuadraticEquation
{
    static void Main()
    {
        bool isValid;
        string inString;
        double a;
        double b;
        double c;

        do
        {
            Console.Write("Please, enter coefficient a: ");
            inString = Console.ReadLine();
            isValid = double.TryParse(inString, out a) && (a >= double.MinValue) && (a <= double.MaxValue);
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
            Console.Write("Please, enter coefficient b: ");
            inString = Console.ReadLine();
            isValid = double.TryParse(inString, out b) && (b >= double.MinValue) && (b <= double.MaxValue);
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
            Console.Write("Please, enter coefficient c: ");
            inString = Console.ReadLine();
            isValid = double.TryParse(inString, out c) && (c >= double.MinValue) && (c <= double.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        if (a == 0)
        {
            Console.WriteLine("Coefficient a can't be 0");
        }
        else
        {
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The equation roots are:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equation has one root x = {0}", x);
            }
            else
            {
                Console.WriteLine("The equation doesn't have real roots");
            }
        }

    }
}