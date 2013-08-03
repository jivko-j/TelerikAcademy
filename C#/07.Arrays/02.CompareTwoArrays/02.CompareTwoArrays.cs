// Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        // To compare arrays element by element their length must be equal.
        uint length = 0;
        bool isValid;

        do
        {
            Console.Write("Please, enter the length of the arrays: ");
            isValid = uint.TryParse(Console.ReadLine(), out length) && length > 0 && length <= uint.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        double[] firstArray = new double[length];
        double[] secondArray = new double[length];

        Console.WriteLine();
        Console.WriteLine("Please, enter elements of the firs array:");

        for (int i = 0; i < length; i++)
        {
            do
            {
                Console.Write("Ellement {0} = ", i);
                isValid = double.TryParse(Console.ReadLine(), out firstArray[i]) && firstArray[i] >= double.MinValue && firstArray[i] <= double.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter valid number");
                    Console.WriteLine();
                }
            }
            while (!isValid);
        }

        Console.WriteLine();
        Console.WriteLine("Please, enter elements of the second array:");

        for (int i = 0; i < length; i++)
        {
            do
            {
                Console.Write("Ellement {0} = ", i);
                isValid = double.TryParse(Console.ReadLine(), out secondArray[i]) && secondArray[i] >= double.MinValue && secondArray[i] <= double.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter valid number");
                    Console.WriteLine();
                }
            }
            while (!isValid);
        }

        Console.WriteLine();
        Console.WriteLine("Result of comarsion of the two arrays:");
        Console.WriteLine();

        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("Element {0} of first array is greater than the same element of the seccond array", i);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("Element {0} of first array is smaller than the same element of the seccond array", i);
            }
            else
            {
                Console.WriteLine("Elements {0} of the two arrays are same", i);
            }
        }
    }
}