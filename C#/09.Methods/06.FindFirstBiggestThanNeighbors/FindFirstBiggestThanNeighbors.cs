/* Write a method that returns the index of the first element in array that is bigger
 * than its neighbors, or -1, if there’s no such element.
 * Use the method from the previous exercise. */

using System;

class FindFirstBiggestThanNeighbors
{
    static void Main()
    {
        int[] myArray = { 8, 5, 4, 2, 1, 5, 8, 2, 7, 1, 3, 5, 4, 9, 8, 9, 0, 1, 7 };
        //int[] myArray = { 1, 5, 6 };
        
        int result = FindFirstBigger(myArray);
        if (result > 0)
        {
            Console.WriteLine("The index of the first element that is bigger than its neighbors is {0}"
                , result);
        }
        else
        {
            Console.WriteLine("There are no element that is bigger than its neighbors");
        }
    }

    static int FindFirstBigger(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (IsBiggerNeighbors(i, array) > 0)
            {
                return i;
            }
        }
        return -1;
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