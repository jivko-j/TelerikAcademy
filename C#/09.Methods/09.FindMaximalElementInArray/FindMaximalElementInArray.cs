/* Write a method that return the maximal element in a portion of array of integers
 * starting at given index. Using it write another method that sorts an array
 * in ascending / descending order. */

using System;

class FindMaximalElementInArray
{
    static void Main()
    {
        //int[] myArray = { 8, 5, 7, 2, 1, 5, 8, 2, 7, 1, 3, 5, 4, 9, 8, 9, 0, 1, 7 };
        int[] myArray = GenerateArray();

        Console.WriteLine("Generated random array is:");
        PrintArray(myArray);

        int startPos = InputNumber("Please, enter start position: ", 0, myArray.Length - 1);
        int endPos = InputNumber("Please, enter end position: ", startPos, myArray.Length - 1);

        int maxPos = MaxElement(startPos, endPos, myArray);

        Console.WriteLine("The maximal element between {0}-th and {1}-th position is {2}",
            startPos, endPos, myArray[maxPos]);

        bool ascending = ChooseSortingOrder();

        SortArray(ascending, myArray);

        Console.WriteLine("Sorted array is:");
        PrintArray(myArray);
            }

    private static bool ChooseSortingOrder()
    {
        bool isValid;
        string inString;
        do
        {
            Console.Write("Choose (A)scending or (D)escending order of sort: ");
            inString = Console.ReadLine().ToLower();
            isValid = inString == "a" || inString == "d";
        } while (!isValid);

        bool ascending = inString == "a";
        return ascending;
    }

    static int[] GenerateArray()
    {
        Random rnd = new Random();
        int[] array = new int[rnd.Next(10, 20)];
        for (int i = 0; i < array.Length; i++)
            array[i] = rnd.Next(100);
        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i]);
            Console.Write(", ");
        }
        Console.WriteLine(array[array.Length - 1]);
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

    static int MaxElement(int startPos, int endPos, int[] array)
    {
        int max = array[startPos];
        int maxPos = startPos;
        for (int i = startPos + 1; i <= endPos; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxPos = i;
            }
        }
        return maxPos;
    }

    static void SortArray(bool ascending, int[] array)
    {
        if (ascending)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(i, MaxElement(0, i, array), array);
            }
        }
        else
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Swap(i, MaxElement(i, array.Length - 1, array), array);
            }
        }
    }

    static void Swap (int pos1, int pos2, int[] array)
{
    int temp = array[pos1];
    array[pos1] = array[pos2];
    array[pos2] = temp;
}
}