/* Write a program, that reads from the console an array of N integers and an integer K,
 * sorts the array and using the method Array.BinSearch() finds the largest number
 * in the array which is ≤ K. */

using System;

class FindLargestNumberLessK
    {
        static void Main()
        {
            bool isValid;
            int k;
            int length;

            do
            {
                Console.Write("Please, enter number K: ");
                isValid = int.TryParse(Console.ReadLine(), out k) && k >= int.MinValue && k <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            } while (!isValid);

            do
            {
                Console.Write("Please, enter length of the array N ( N > 1): ");
                isValid = int.TryParse(Console.ReadLine(), out length) && length > 1 && length <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            } while (!isValid);

            int[] myArray = new int[length];

            Console.WriteLine();
            Console.WriteLine("Please, enter elements of the array: ");
            for (int i = 0; i < length; i++)
            {
                do
                {
                    Console.Write("Element {0} = ", i);
                    isValid = int.TryParse(Console.ReadLine(), out myArray[i]) && myArray[i] >= int.MinValue && myArray[i] <= int.MaxValue;
                    if (!isValid)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please, enter correct number");
                        Console.WriteLine();
                    }
                } while (!isValid);
            }

            Array.Sort(myArray);

            int position = Array.BinarySearch(myArray, k);

            // If k is not found, BinarySearch returns 
            if (position < 0)
            {
                position = ~position - 1;
            }

            if (position < 0)
            {
                Console.WriteLine("There are no number in the array <= {0}", k);
            }
            else
            {
                Console.WriteLine("Number {0} is the largest number <= {1}", myArray[position], k);
            }
        }
    }