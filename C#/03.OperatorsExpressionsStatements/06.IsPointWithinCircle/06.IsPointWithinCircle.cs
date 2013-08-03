//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class IsPointWithinCircle
{
    static void Main()
    {
        float centreX = 0f;
        float centreY = 0f;
        float radius = 5f;

        float pointX;
        float pointY;
        bool isValid;

        do
        {
            Console.Write("Please, enter X: ");
            string inNumberStr = Console.ReadLine();
            isValid = float.TryParse(inNumberStr, out pointX) && (pointX >= float.MinValue) && (pointX <= float.MaxValue);
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
            Console.Write("Please, enter Y: ");
            string inNumberStr = Console.ReadLine();
            isValid = float.TryParse(inNumberStr, out pointY) && (pointY >= float.MinValue) && (pointY <= float.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        bool pointIsWithinCircle = (pointX - centreX) * (pointX - centreX)
            + (pointY - centreY) * (pointY - centreY) < radius * radius;

        Console.WriteLine();
        Console.WriteLine("Point with coordinates");
        Console.WriteLine("X = " + pointX);
        Console.WriteLine("Y = " + pointY);
        Console.WriteLine("Is " + (pointIsWithinCircle ? "" : "not ") + "within the circle K(O, 5)");
    }
}