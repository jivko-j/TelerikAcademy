// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class FillAndPrintMatrix
{
    static void Main()
    {
        bool isValid;
        int size;

        do
        {
            // Size is limited to 19 to fit row at console 
            Console.Write("Plese, entetr size of the matrix (2 - 19):");
            isValid = int.TryParse(Console.ReadLine(), out size) && size > 1 && size < 20;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        } while (!isValid);

        int[,] matrix = new int[size, size];

        FillMatrixA(matrix, size);

        PrintMatrix(matrix, size, "A");

        FillMatrixB(matrix, size);

        PrintMatrix(matrix, size, "B");

        FillMatrixC(matrix, size);

        PrintMatrix(matrix, size, "C");

        FillMatrixD(matrix, size);

        PrintMatrix(matrix, size, "D");

    }

    private static void FillMatrixA(int[,] matrix, int size)
    {
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = col * size + row + 1;
            }
        }
    }

    private static void FillMatrixB(int[,] matrix, int size)
    {
        for (int row = 0; row < size; row++)
        {
            //Fill even columns
            for (int col = 0; col < size; col += 2)
            {
                matrix[row, col] = col * size + row + 1;
            }

            // Fill odd columns
            for (int col = 1; col < size; col += 2)
            {
                matrix[row, col] = col * size + (size - row);
            }
        }
    }

    private static void FillMatrixC(int[,] matrix, int size)
    {
        // Fill matrix type C diagonaly
        int row, col;
        int counter = 1;

        // Fill diagonals starts from left column
        for (int diagonal = 0; diagonal < size; diagonal++)
        {
            row = size - diagonal - 1;
            col = 0;
            while (row < size)
            {
                matrix[row++, col++] = counter++;
            }
        }

        // Fill diagonals starts from first row
        for (int diagonal = 1; diagonal < size; diagonal++)
        {
            row = 0;
            col = diagonal;
            while (col < size)
            {
                matrix[row++, col++] = counter++;
            }
        }
    }

    private static void FillMatrixD(int[,] matrix, int size)
    {
        // Matrix type D - fill spiral
        int row, col;
        int counter = 1;
        int revolution = 0;

        while (counter <= size * size)
        {
            // Down
            col = revolution;
            for (row = revolution; row < size - revolution - 1; row++)
            {
                matrix[row, col] = counter++;
            }

            // Right
            row = size - revolution - 1;
            for (col = revolution; col < size - revolution - 1; col++)
            {
                matrix[row, col] = counter++;
            }

            // Up
            col = size - revolution - 1;
            for (row = size - revolution - 1; row > revolution; row--)
            {
                matrix[row, col] = counter++;
            }

            // Left
            row = revolution;
            for (col = size - revolution - 1; col > revolution; col--)
            {
                matrix[row, col] = counter++;
            }

            // Center element when size is odd
            if (size % 2 > 0 && revolution + 1 == size / 2)
            {
                matrix[size / 2, size / 2] = counter++;
            }

            revolution++;
        }
    }


    private static void PrintMatrix(int[,] matrix, int size, string text)
    {
        Console.WriteLine("Matrix type {0}", text);
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}