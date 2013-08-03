/* Write a program that can solve these tasks:
 * Reverses the digits of a number
 * Calculates the average of a sequence of integers
 * Solves a linear equation a * x + b = 0
 * 		Create appropriate methods.
 * 		Provide a simple text-based menu for the user to choose which task to solve.
 * 		Validate the input data:
 * The decimal number should be non-negative
 * The sequence should not be empty
 * a should not be equal to 0 */

using System;
using System.Text;
using System.Linq;

class ProgramWith3Tasks
{
    static void Main()
    {
        int choose = 0;
        do
        {
            choose = Menu();
            switch (choose)
            {
                case 1: ReverseDigitsOfNumber(); break;
                case 2: AverageOfSequence(); break;
                case 3: LinearEquation(); break;
            }
        } while (choose != 0);

    }
    static int Menu()
    {
        Console.WriteLine();
        Console.WriteLine("Please, select task:");
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear equation a * x + b = 0");
        Console.WriteLine("0. Exit");
        Console.Write("Enter 1, 2, 3 or 0: ");

        bool isValid;
        int choose;
        do
        {
            isValid = int.TryParse(Console.ReadLine(), out choose) &&
                (choose == 1 || choose == 2 || choose == 3 || choose == 0);
        } while (!isValid);
        return choose;
    }

    static void ReverseDigitsOfNumber()
    {
        Console.WriteLine();
        Console.WriteLine("Reverse the digits of a number");

        decimal inputNumber = InputNumber("Please, enter decimal number: ", 0, decimal.MaxValue);

        decimal outputNumber = ReverseDigits(inputNumber);

        Console.WriteLine("Number with reversed digits is: {0}", outputNumber);
    }

    static decimal InputNumber(string message, decimal min, decimal max)
    {
        bool isValid;
        decimal output;
        do
        {
            Console.Write(message);
            isValid = decimal.TryParse(Console.ReadLine(), out output) && output >= min && output <= max;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        } while (!isValid);
        return output;
    }

    static int InputNumberException(string message, int min, int max, int exception)
    {
        bool isValid;
        int output;
        do
        {
            Console.Write(message);
            isValid = int.TryParse(Console.ReadLine(), out output)
                && output >= min && output <= max && output != exception;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        } while (!isValid);
        return output;
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

    static decimal ReverseDigits(decimal inputNumber)
    {
        string numberAsString = inputNumber.ToString();
        StringBuilder newSring = new StringBuilder();

        for (int i = numberAsString.Length - 1; i >= 0; i--)
        {
            newSring.Append(numberAsString[i]);
        }

        return decimal.Parse(newSring.ToString());
    }

    static void AverageOfSequence()
    {
        Console.WriteLine();
        Console.WriteLine("Calculate the average of a sequence of integers");

        int length = InputNumber("Please, enter length of the sequence: ", 1, int.MaxValue);
        int[] myArray = new int[length];
        myArray = InputArray("Please, enter elements of the sequence: ",
            myArray, int.MinValue, int.MaxValue);

        Console.WriteLine("The average of the sequence is {0}", myArray.Average());
    }

    static int[] InputArray(string message, int[] array, int min, int max)
    {
        Console.WriteLine(message);
        for (int i = 0; i < array.Length; i++)
        {
            bool isValid;
            int output;
            do
            {
                Console.Write("Element {0}: ", i);
                isValid = int.TryParse(Console.ReadLine(), out output) && output >= min && output <= max;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            } while (!isValid);
            array[i] = output;
        }
        return array;
    }

    static void LinearEquation()
    {
        Console.WriteLine();
        Console.WriteLine("Solve a linear equation a * x + b = 0");
        int a = InputNumberException("Please, enter a (a != 0): ", int.MinValue, int.MaxValue, 0);
        int b = InputNumber("Please, enter b: ", int.MinValue, int.MaxValue);

        double x = -b / (double)a;
        Console.WriteLine("x = {0}", x);
    }
}