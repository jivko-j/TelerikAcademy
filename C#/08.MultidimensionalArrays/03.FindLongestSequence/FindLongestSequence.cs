/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets
 * of several neighbor elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix. */

using System;

class FindLongestSequence
{
    static void Main()
    {
        string[,] matrix = {
        {"at", "on", "are", "is", "is", "on"},
        {"at", "are", "are", "on", "is", "at"},
        {"on", "on", "are", "is", "are", "on"},
        {"at", "are", "are", "are", "is", "at"},
        {"at", "on", "on", "on", "are", "on"},
                           };
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int maxSetLenght = 0;
        int maxSetRowStart = 0;
        int maxSetColStart = 0;
        string maxSetType = "";
        string maxSetValue = "";
        int setLenght;

        // Searching by rows
        for (int row = 0; row < rows; row++)
        {
            for (int colStart = 0; colStart < cols - 1; colStart++)
            {
                setLenght = 1;
                for (int colEnd = colStart + 1; colEnd < cols - colStart; colEnd++)
                {
                    if (string.Compare(matrix[row, colEnd], matrix[row, colEnd - 1]) == 0)
                    {
                        setLenght++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (setLenght > maxSetLenght)
                {
                    maxSetLenght = setLenght;
                    maxSetRowStart = row;
                    maxSetColStart = colStart;
                    maxSetType = "column";
                    maxSetValue = matrix[row, colStart];
                }
            }
        }

        // Searching by columns
        for (int col = 0; col < cols; col++)
        {
            for (int rowStart = 0; rowStart < rows - 1; rowStart++)
            {
                setLenght = 1;
                for (int rowEnd = rowStart + 1; rowEnd < rows - rowStart; rowEnd++)
                {
                    if (string.Compare(matrix[rowEnd, col], matrix[rowEnd - 1, col]) == 0)
                    {
                        setLenght++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (setLenght > maxSetLenght)
                {
                    maxSetLenght = setLenght;
                    maxSetRowStart = rowStart;
                    maxSetColStart = col;
                    maxSetType = "row";
                    maxSetValue = matrix[rowStart, col];
                }
            }
        }

        // Diagonals right to left

        // Diagonals starting from first row

        for (int diagonal = 1; diagonal < cols; diagonal++)
        {
            for (int rowStart = 0, colStart = diagonal; rowStart < rows - 1 && colStart > 0; rowStart++, colStart--)
            {
                setLenght = 1;
                for (int row = rowStart + 1, col = colStart - 1; row < rows  && col >= 0; row++, col--)
                {
                    if (string.Compare(matrix[row, col], matrix[row - 1, col + 1]) == 0)
                    {
                        setLenght++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (setLenght > maxSetLenght)
                {
                    maxSetLenght = setLenght;
                    maxSetRowStart = rowStart;
                    maxSetColStart = colStart;
                    maxSetType = "diagonal";
                    maxSetValue = matrix[rowStart, colStart];
                }
            }
        }

        // Diagonals starting from last column

        for (int diagonal = 1; diagonal < rows - 1; diagonal++)
        {
            for (int rowStart = diagonal, colStart = cols-1; rowStart < rows - 1 && colStart > 0; rowStart++, colStart--)
            {
                setLenght = 1;
                for (int row = rowStart + 1, col = colStart - 1; row < rows && col >= 0; row++, col--)
                {
                    if (string.Compare(matrix[row, col], matrix[row - 1, col + 1]) == 0)
                    {
                        setLenght++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (setLenght > maxSetLenght)
                {
                    maxSetLenght = setLenght;
                    maxSetRowStart = rowStart;
                    maxSetColStart = colStart;
                    maxSetType = "diagonal";
                    maxSetValue = matrix[rowStart, colStart];
                }
            }
        }

        // Diagonals left to right

        // Diagonals starting from first column

        for (int diagonal = rows-2; diagonal >= 0; diagonal--)
        {
            for (int rowStart = diagonal, colStart = 0; rowStart < rows - 1 && colStart < cols - 1; rowStart++, colStart++)
            {
                setLenght = 1;
                for (int row = rowStart + 1, col = colStart + 1; row < rows && col < cols; row++, col++)
                {
                    if (string.Compare(matrix[row, col], matrix[row - 1, col - 1]) == 0)
                    {
                        setLenght++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (setLenght > maxSetLenght)
                {
                    maxSetLenght = setLenght;
                    maxSetRowStart = rowStart;
                    maxSetColStart = colStart;
                    maxSetType = "diagonal";
                    maxSetValue = matrix[rowStart, colStart];
                }
            }
        }

        // Diagonals starting from first row

        for (int diagonal = 1; diagonal < cols - 1; diagonal++)
        {
            for (int rowStart = 0, colStart = diagonal ; rowStart < rows - 1 && colStart < cols - 1; rowStart++, colStart++)
            {
                setLenght = 1;
                for (int row = rowStart + 1, col = colStart + 1; row < rows && col < cols; row++, col++)
                {
                    if (string.Compare(matrix[row, col], matrix[row - 1, col - 1]) == 0)
                    {
                        setLenght++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (setLenght > maxSetLenght)
                {
                    maxSetLenght = setLenght;
                    maxSetRowStart = rowStart;
                    maxSetColStart = colStart;
                    maxSetType = "diagonal";
                    maxSetValue = matrix[rowStart, colStart];
                }
            }
        }

        // Print sequence

        if (maxSetLenght > 1)
        {
            Console.WriteLine("Longest sequence is {0} from element {1}, {2} and is {3} elements long"
                , maxSetType, maxSetRowStart, maxSetColStart, maxSetLenght);
            Console.Write("The sequence is: ");
            for (int i = 1; i < maxSetLenght; i++)
            {
                Console.Write("{0}, ",maxSetValue);
            }
            Console.WriteLine(maxSetValue);
        }
        else
        {
            Console.WriteLine("There are no sequence of equal elements in the matrix");
        }
    }
}