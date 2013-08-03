/* Write a program that sorts an array of strings using the quick sort algorithm
 * (find it in Wikipedia) */

using System;

class QuickSort
{
    static public int Partition(string[] array, int left, int right)
    {
        // Choose last element of partition for pivot
        string pivot = array[right];
        int i = left;

        for (int j = left; j < right; j++)
        {
            // Move elements smaller than pivot at left
            if (String.Compare(array[j], pivot) < 0)
            {
                swap(array, i, j);
                i++;
            }
        }
        // Move pivot after last element, smaller than pivot
        swap(array, i, right);
        return i;
    }


    static public void swap(string[] array, int a, int b)
    {
        string temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }


    static public void QuickSortRecursive(string[] array, int left, int right)
    {
        // Split array at parts recursively
        if (left < right)
        {
            int pivot = Partition(array, left, right);
            if (pivot > 1)
            {
                QuickSortRecursive(array, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSortRecursive(array, pivot + 1, right);
            }
        }
    }


    static void Main()
    {
        string[] myArray = { "two", "first", "cell", "fall", "aloha", "where", "end", "who", "fall", "end", "another" };
        int length = myArray.Length;

        QuickSortRecursive(myArray, 0, length - 1);

        Console.WriteLine("Sorted array is:");

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}