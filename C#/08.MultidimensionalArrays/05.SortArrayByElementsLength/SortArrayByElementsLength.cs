/* You are given an array of strings. Write a method that sorts the array
 * by the length of its elements (the number of characters composing them). */

using System;

class SortArrayByElementsLength
{
    static void Main()
    {
        string[] myArray = { "two", "first", "cell", "a", "almond", "where", "downtown", "on", "fall", "end", "another", "one"};

        SortByLength(myArray);

        Console.WriteLine("Sorted by string length array is:");

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }

    static void SortByLength(string[] myArray)
    {
        for (int i = myArray.Length; i > 0 ; i--)
        {
            for (int j = 1; j < i; j++)
            {
                if (myArray[j - 1].Length > myArray[j].Length)
                {
                    swap(myArray, j - 1, j);
                }
            }
        }
    }

    static public void swap(string[] array, int a, int b)
    {
        string temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}