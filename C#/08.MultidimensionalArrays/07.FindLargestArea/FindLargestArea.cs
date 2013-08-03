/* Write a program that finds the largest area of equal neighbor elements
 * in a rectangular matrix and prints its size. */
/* Hint: you can use the algorithm "Depth-first search"
 * or "Breadth-first search" (find them in Wikipedia). */

using System;

class FindLargestArea
{
    static int[,] matrix = {
                            {1, 3, 2, 2, 2, 4},
                            {3, 3, 3, 2, 4, 4},
                            {4, 3, 1, 2, 3, 3},
                            {4, 3, 1, 3, 3, 1},
                            {4, 3, 3, 3, 1, 1}
                           };
    
    static bool[,] searched = new bool[matrix.GetLength(0), matrix.GetLength(1)];
    static int searchFor;
    static int currentCount;

    static void Main()
    {
        int maxElementsCount = 0;
        int maxElement = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                searchFor = matrix[row, col];
                currentCount = 0;
                DepthFirstSearch(row, col);
                //Console.WriteLine("* {0} {1} *", matrix[row, col], currentCount);

                if (currentCount > maxElementsCount)
                {
                    maxElementsCount = currentCount;
                    maxElement = matrix[row, col];
                }
            }
        }
        Console.WriteLine("Largest area of equal neighbor elements has {0} elements with value {1}",
            maxElementsCount, maxElement);
    }

    static void DepthFirstSearch(int row, int col)
    {
        // Check if search is winthin the matrih, if element is not marked as counted and
        // if element is with same value as searched
        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) &&
            searched[row, col] == false && matrix[row, col] == searchFor)
        {
            searched[row, col] = true;
            currentCount++;
            // Check all neighbor elements
            DepthFirstSearch(row, col - 1);
            DepthFirstSearch(row, col + 1);
            DepthFirstSearch(row - 1, col);
            DepthFirstSearch(row + 1, col);
        }
    }
}