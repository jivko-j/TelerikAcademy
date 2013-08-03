/* Write methods to calculate minimum, maximum, average, sum and product of given set
 * of integer numbers. Use variable number of arguments. */

using System;

class MathOperationsAtIntegers
{
    static void Main()
    {
        int[] myArray;

        int length = InputNumber("Please, enter length of the set or 0 for autogeneration: ", 0, int.MaxValue);

        if (length == 0)
        {
            myArray = GenerateArray();
        }
        else
        {
            myArray = new int[length];
            myArray = InputArray("Please, enter elements of the set: ",
                myArray, int.MinValue, int.MaxValue);
        }
        Console.WriteLine();
        Console.WriteLine("The set is:");
        PrintArray(myArray);

        Console.WriteLine();
        Console.WriteLine("The minimal element in the set is: {0}", ArrayMin(myArray));

        Console.WriteLine();
        Console.WriteLine("The maximal element in the set is: {0}", ArrayMax(myArray));

        Console.WriteLine();
        Console.WriteLine("The average of the set is: {0}", ArrayAverage(myArray));

        Console.WriteLine();
        Console.WriteLine("The sum of the set is: {0}", ArraySum(myArray));

        Console.WriteLine();
        Console.WriteLine("The product of the elements of the set is: {0}", ArrayProduct(myArray));
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

    static int[] GenerateArray()
    {
        Random rnd = new Random();
        int[] array = new int[rnd.Next(10, 20)];
        for (int i = 0; i < array.Length; i++)
            array[i] = rnd.Next(100);
        return array;
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

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i]);
            Console.Write(", ");
        }
        Console.WriteLine(array[array.Length - 1]);
    }

    static int ArrayMax(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static int ArrayMin(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static int ArraySum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
                sum += array[i];
        }
        return sum;
    }

    static double ArrayProduct(int[] array)
    {
        double product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static double ArrayAverage(int[] array)
    {
        int sum = ArraySum(array);
        return sum / (double)array.Length;
    }
    }