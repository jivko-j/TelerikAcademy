/* Write a program that reads two integer numbers N and K and an array of N elements
 * from the console. Find in the array those K elements that have maximal sum. */

using System;

class KElementsMaxSum
{
    static void Main()
    {
        uint length = 0;
        uint k = 0;
        bool isValid;

        do
        {
            Console.Write("Please, enter the length of the array: ");
            isValid = uint.TryParse(Console.ReadLine(), out length) && length > 0 && length <= uint.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        do
        {
            Console.Write("Please, enter number K: ( K <= lenght) ");
            isValid = uint.TryParse(Console.ReadLine(), out k) && k > 0 && k < length;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        double[] array = new double[length];

        Console.WriteLine();
        Console.WriteLine("Please, enter the elements of the array:");

        for (int i = 0; i < length; i++)
        {
            do
            {
                Console.Write("Ellement {0} = ", i);
                isValid = double.TryParse(Console.ReadLine(), out array[i]) && array[i] >= double.MinValue && array[i] <= double.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter valid number");
                    Console.WriteLine();
                }
            }
            while (!isValid);
        }

        Array.Sort(array);

        double sum = 0;

        Console.WriteLine("{0} elements with maximal sum in the array are:", k);
        for (int i = (int)length - 1 ; i > length - k - 1; i--)
        {
            Console.WriteLine(array[i]);
            sum += array[i];
        }
        Console.WriteLine("Sum is {0}", sum);
    }
}