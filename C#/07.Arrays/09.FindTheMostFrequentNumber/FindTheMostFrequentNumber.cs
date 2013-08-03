/* Write a program that finds the most frequent number in an array.
 * Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times) */

using System;

class FindTheMostFrequentNumber
{
    static void Main()
    {
        //Array input
        int length = 0;
        bool isValid;

        do
        {
            Console.Write("Please, enter the length of the array: ( > 2 ) ");
            isValid = int.TryParse(Console.ReadLine(), out length) && length > 2 && length <= int.MaxValue;
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

        // Finding the most frequent number

        int maxCount = 0;
        double max = 0;
        int currentMaxCount = 1;

        for (int i = 0; i < length; i++)
        {
            currentMaxCount = 1;

            for (int j = i + 1; j < length; j++)
            {
                if (myArray[i] == myArray[j])
                {
                    currentMaxCount++;
                }
            }
            
            if (currentMaxCount > maxCount)
            {
                maxCount = currentMaxCount;
                max = myArray[i];
            }
        }

        if (maxCount > 1)
        {
            Console.WriteLine("The most frequent number is {0} ({1} times)", max, maxCount);
        }
        else
        {
            Console.WriteLine("There is no equal numbers in the array");
        }
    }
}