// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        float radius;
        bool isValid;
        string inString;

        do
        {
            Console.Write("Please, enter circle's radius: ");
            inString = Console.ReadLine();
            isValid = float.TryParse(inString, out radius) && (radius >= float.MinValue) && (radius <= float.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        float perimeter = 2f * (float)Math.PI * radius;
        float area = (float)Math.PI * radius * radius;

        Console.WriteLine("Circle with radius {0} have perimeter {1} and area {2}", radius, perimeter, area);
    }
}