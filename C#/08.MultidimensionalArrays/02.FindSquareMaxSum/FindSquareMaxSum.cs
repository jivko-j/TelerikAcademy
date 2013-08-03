/* Write a program that reads a rectangular matrix of size N x M and finds 
 * in it the square 3 x 3 that has maximal sum of its elements. */

using System;

class FindSquareMaxSum
{
    static void Main()
    {
        bool isValid;
        int rows, cols;
        double[,] matrix;

        Console.Write("There are predefined matrix. Do you want to enter your matrix? (Y)es?");
        if (Console.ReadLine().ToLower() == "y")
        {
            do
            {
                Console.Write("Plese, entetr size N of the matrix (N > 3):");
                isValid = int.TryParse(Console.ReadLine(), out rows) && rows > 2 && rows < int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            } while (!isValid);

            do
            {
                Console.Write("Plese, entetr size M of the matrix (M > 3):");
                isValid = int.TryParse(Console.ReadLine(), out cols) && cols > 2 && cols < int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            } while (!isValid);

            matrix = new double[rows, cols];

            Console.WriteLine("Please, enter elements of the matrix:");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    do
                    {
                        Console.Write("Element {0}, {1} = ", row, col);
                        isValid = double.TryParse(Console.ReadLine(), out matrix[row, col]) && matrix[row, col] > double.MinValue && matrix[row, col] < double.MaxValue;
                        if (!isValid)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please, enter correct number");
                            Console.WriteLine();
                        }
                    } while (!isValid);
                }
            }
        }
        else
        {
            rows = 6;
            cols = 5;

            double[,] predefMatrix = {
            {22, 3, 4, -1, 5},
            {5, -24, 42, 43, -5},
            {-23, 6, -23, 43, 4},
            {6, -24, -2, 24, 42},
            {-31, -34, 123, 43, 78},
            {32, 435, 5, -1, 11}
            };

            matrix = predefMatrix;
        }

        int platformRows = 3;
        int platformCols = 3;
        double sum;
        double maxSum = double.MinValue;
        int maxSumRow = 0, maxSumCol = 0;

        for (int row = 0; row <= rows - platformRows; row++)
        {
            for (int col = 0; col <= cols - platformCols; col++)
            {
                sum = SumPlatform(matrix, row, col, platformRows, platformCols);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxSumRow = row;
                    maxSumCol = col;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Platform {0} x {1} with maxumum sum is:", platformRows, platformCols);
        for (int row = maxSumRow; row < maxSumRow + platformRows; row++)
        {
            for (int col = maxSumCol; col < maxSumCol + platformCols; col++)
            {
                Console.Write("{0,4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Sum is {0}", maxSum);
    }

    private static double SumPlatform(double[,] matrix, int row, int col, int platformRows, int platformCols)
    {
        double sum;
        sum = 0;
        for (int sumRows = row; sumRows < row + platformRows; sumRows++)
        {
            for (int sumCols = col; sumCols < col + platformCols; sumCols++)
            {
                sum += matrix[sumRows, sumCols];
            }
        }
        return sum;
    }
}