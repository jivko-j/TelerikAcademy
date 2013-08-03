/* Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from the console and prints the biggest of them
 * using the method GetMax(). */

using System;

class GetMaxMethod
{
    static void Main()
    {
        int a = InputNumber("Please, enter number A: ", int.MinValue, int.MaxValue);
        int b = InputNumber("Please, enter number B: ", int.MinValue, int.MaxValue);
        int c = InputNumber("Please, enter number C: ", int.MinValue, int.MaxValue);

        int max = GetMax(a, b);
        max = GetMax(max, c);

        Console.WriteLine("The biggest number is {0}", max);
    }

    static int InputNumber(string message, int min, int max)
    {
        bool isValid;
        int output;
        do
        {
            Console.Write(message);
            isValid = int.TryParse(Console.ReadLine(), out output) && output >= min && output <= max;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        } while (!isValid);
        return output;
    }

    static int GetMax(int a, int b)
    {
        int max = Math.Max(a, b);
        return max;
    }
}