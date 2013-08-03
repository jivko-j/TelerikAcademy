/* Write a program that gets two numbers from the console and prints the greater of them.
 * Don’t use if statements. */

using System;

class GreaterNumber
{
    static void Main()
    {
        bool isValid;
        string inString;
        float number1;
        float number2;
        
        do
        {
            Console.Write("Please, enter first number: ");
            inString = Console.ReadLine();
            isValid = float.TryParse(inString, out number1) && (number1 >= float.MinValue) && (number1 <= float.MaxValue);
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
            Console.Write("Please, enter second number: ");
            inString = Console.ReadLine();
            isValid = float.TryParse(inString, out number2) && (number2 >= float.MinValue) && (number2 <= float.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        float greater = (number1 > number2) ? number1 : number2;
        Console.WriteLine("The greather of numbers {0} and {1} is {2}", number1, number2, greater );
    }
}