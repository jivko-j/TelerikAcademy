/* Write a program that finds the index of given element in a sorted array of integers
 * by using the binary search algorithm (find it in Wikipedia). */

using System;

class BinarySearch
{
    static void Main()
    {
        int length = 0;
        int givenElement = 0;
        bool isValid;

        do
        {
            Console.Write("Please, enter searched element: ");
            isValid = int.TryParse(Console.ReadLine(), out givenElement) && givenElement > int.MinValue && givenElement <= int.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        //Array input
        do
        {
            Console.Write("Please, enter the length of the array: ( > 1 ) ");
            isValid = int.TryParse(Console.ReadLine(), out length) && length > 1 && length <= int.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        int[] myArray = new int[length];

        Console.WriteLine();
        Console.WriteLine("Please, enter the elements of the array:");

        for (int i = 0; i < length; i++)
        {
            do
            {
                Console.Write("Ellement {0} = ", i);
                isValid = int.TryParse(Console.ReadLine(), out myArray[i]) && myArray[i] >= int.MinValue && myArray[i] <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter valid number");
                    Console.WriteLine();
                }
            }
            while (!isValid);
        }

        Array.Sort(myArray);

        Console.WriteLine();
        Console.WriteLine("Sorted array is:");
        Console.WriteLine("      Index:        Value:");

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("{0,12}  {1,12}", i, myArray[i]);
        }

        // Binary search

        bool found = false;
        int first = 0;
        int last = length;
        int mid = 0;

        while (first <= last && !found)
        {
            mid = (first + last) / 2;

            if (givenElement > myArray[mid])
            {
                first = mid + 1;
            }

            else if (givenElement < myArray[mid])
            {
                last = mid - 1;
            }
            else
            {
                found = true;
            }
        }

        Console.WriteLine();

        if (found)
        {
            Console.WriteLine("Element with value {0} was found in sorted array at position {1}", givenElement, mid);
        }
        else
        {
            Console.WriteLine("Element with value {0} was not found", givenElement);
        }
    }
}