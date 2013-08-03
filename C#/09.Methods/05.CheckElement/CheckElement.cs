/* Write a method that checks if the element at given position in given array of integers
 * is bigger than its two neighbors (when such exist). */

using System;

class CheckElement
{
    static void Main()
    {
        int[] myArray = { 8, 5, 7, 2, 1, 5, 8, 2, 7, 1, 3, 5, 4, 9, 8, 9, 0, 1, 7 };

        int position = InputNumber("Please, enter position ( >= 0 ): ", 0, int.MaxValue);

        int result = IsBiggerNeighbors(position, myArray);

        if (result > 0)
        {
            Console.WriteLine("Element at position {0} is bigger than its two neighbors", position);
        }
        else if (result == 0)
        {
            Console.WriteLine("Element at position {0} is not bigger than its two neighbors", position);
        }
        else
        {
            Console.WriteLine("There are no element with two neigboors at position {0}", position);
        }
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

    static int IsBiggerNeighbors(int position, int[] array)
    {
        // Check if searched position is within array, ant there are two neighbors
        if (position < 1 || position > array.Length - 2)
        {
            return -1; // No such element
        }
        else if (array[position] > array[position - 1] && array[position] > array[position + 1])
        {
            return 1; // Bigger than two neighbors
        }
        else
        {
            return 0; // Not bigger than two neighbors
        }
    }
}