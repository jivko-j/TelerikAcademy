// Write an expression that calculates rectangle’s area by given width and height.

using System;
class RectanglesArea
{
    static void Main()
    {
        float width;
        float height;
        bool isValid;

        do
        {
            Console.Write("Please, enter rectangle’s width: ");
            string inNumberStr = Console.ReadLine();
            isValid = float.TryParse(inNumberStr, out width) && (width > 0) && (width <= float.MaxValue); 
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
            Console.Write("Please, enter rectangle’s height: ");
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

        float area = height * width;

        Console.WriteLine("A rectangle with width {0} and height {1} have area {2}", height, width, area);
    }
}