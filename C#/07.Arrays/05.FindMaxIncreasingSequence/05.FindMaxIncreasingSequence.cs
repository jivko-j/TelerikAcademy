/*Write a program that finds the maximal increasing sequence in an array.
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}. */


using System;

class FindMaxIncreasingSequence
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

            int currentMaxStart = 0;
            int currentMaxLenght = 1;
            int maxStart = 0;
            int maxLenght = 1;

            for (int i = 1; i < length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    currentMaxLenght++;
                    if (currentMaxLenght > maxLenght)
                    {
                        maxStart = currentMaxStart;
                        maxLenght = currentMaxLenght;
                    }
                }
                else
                {
                    currentMaxStart = i;
                    currentMaxLenght = 1;
                }
            }
            if (maxLenght > 1)
            {
                Console.WriteLine("The maximal increasing sequence in the array start from");
                Console.WriteLine("element No {0} and is {1} elements long", maxStart, maxLenght);
                Console.Write("The sequence is:{");
                for (int i = maxStart; i < maxStart + maxLenght - 1; i++)
                {
                    Console.Write("{0}, ", array[i]);
                }
                Console.Write("{0}", array[maxStart + maxLenght - 1]);
                Console.WriteLine("}");
            }
            else
            {
                Console.WriteLine("There isn't increasing sequence in the array");
            }
        }
    }