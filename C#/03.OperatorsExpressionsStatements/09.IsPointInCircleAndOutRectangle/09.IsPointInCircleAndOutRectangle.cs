/* Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
 * and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class IsPointInCircleAndOutRectangle
{
    static void Main()
    {
        float centreX = 1f;
        float centreY = 1f;
        float radius = 3f;
        float topLeftX = -1;
        float topLeftY = 1;
        float width = 6;
        float height = 2;

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

        // First line checks if the point is within the circle.
        // Second line checks if the point is out of the rectangle.

        bool checkPoint = ((pointX - centreX) * (pointX - centreX) + (pointY - centreY) * (pointY - centreY) < radius * radius) &&
           !((pointX > topLeftX) && (pointX < (topLeftX + width)) && (pointY < topLeftY) && (pointY > (topLeftY - height)));

        Console.WriteLine();
        Console.WriteLine("Point with coordinates");
        Console.WriteLine("X = " + pointX);
        Console.WriteLine("Y = " + pointY);
        Console.WriteLine("Is " + (checkPoint ? "" : "not ") + "within the circle K( (1,1), 3)");
        Console.WriteLine("and out of the rectangle R(top=1, left=-1, width=6, height=2) ");
    }
}