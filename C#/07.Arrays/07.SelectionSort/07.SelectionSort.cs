/* Sorting an array means to arrange its elements in increasing order. Write a program to sort
 * an array. Use the "selection sort" algorithm: Find the smallest element, move it at the
 * first position, find the smallest from the rest, move it at the second position, etc. */

using System;

class SelectionSort
{
    static void Main()
    {
        uint length = 0;
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

        double[] myArray = new double[length];

        Console.WriteLine();
        Console.WriteLine("Please, enter the elements of the array:");

        for (int i = 0; i < length; i++)
        {
            do
            {
                Console.Write("Ellement {0} = ", i);
                isValid = double.TryParse(Console.ReadLine(), out myArray[i]) && myArray[i] >= double.MinValue && myArray[i] <= double.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter valid number");
                    Console.WriteLine();
                }
            }
            while (!isValid);
        }

        int minIndex;
        double temp;

        for (int i = 0; i < length - 1; i++)
        {
            minIndex = i;

            for (int j = i + 1; j < length; j++)
            {
                if (myArray[j] < myArray[i])
                {
                    minIndex = j;
                }
            }
            temp = myArray[i];
            myArray[i] = myArray[minIndex];
            myArray[minIndex] = temp;
        }

        Console.WriteLine("Sorted array is:");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}