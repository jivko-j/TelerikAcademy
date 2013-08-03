// Extend the program to support also subtraction and multiplication of polynomials.

using System;

class MathOperationsAtPolynominals
{
    static void Main()
    {
        int[] coeffA = { 3, -4, 5, 6, 9 };
        int[] coeffB = { 7, 3, -5, 2 };

        Console.WriteLine("The coeficients of the polynomials are:");
        Console.WriteLine("Polynomial A:");
        PrintArray(coeffA);
        Console.WriteLine();
        Console.WriteLine("Polynomial B:");
        PrintArray(coeffB);
        
        int[] result = SumPolynomials(coeffA, coeffB);

        Console.WriteLine();
        Console.WriteLine("The sum of polynominals is polynominal with coefficients:");
        PrintArray(result);

        result = SubstractPolynomials(coeffA, coeffB);

        Console.WriteLine();
        Console.WriteLine("The substraction of polynominals is polynominal with coefficients:");
        PrintArray(result);

        result = MultiplyPolynomials(coeffA, coeffB);

        Console.WriteLine();
        Console.WriteLine("The multiplication of polynominals is polynominal with coefficients:");
        PrintArray(result);

    }

    static int[] SumPolynomials(int[] a, int[] b)
    {
        int shorterLength = Math.Min(a.Length, b.Length);
        int longerLength = Math.Max(a.Length, b.Length);
        int[] result = new int[longerLength];


        //Sum coefficients to the smaller degree
        for (int i = 0; i < shorterLength; i++)
        {
            result[i] = a[i] + b[i];
        }

        // If one polynominal has higher degree copy its coefficients
        if (a.Length > b.Length)
        {
            for (int i = shorterLength; i < a.Length; i++)
            {
                result[i] = a[i];
            }
        }
        else if (b.Length > a.Length)
        {
            for (int i = shorterLength; i < b.Length; i++)
            {
                result[i] = b[i];
            }
        }
        return result;
    }

    static int[] SubstractPolynomials(int[] a, int[] b)
    {
        int shorterLength = Math.Min(a.Length, b.Length);
        int longerLength = Math.Max(a.Length, b.Length);
        int[] result = new int[longerLength];


        //Substract coefficients to the smaller degree
        for (int i = 0; i < shorterLength; i++)
        {
            result[i] = a[i] - b[i];
        }

        // If one polynominal has higher degree copy its coefficients
        if (a.Length > b.Length)
        {
            for (int i = shorterLength; i < a.Length; i++)
            {
                result[i] = a[i];
            }
        }
        else if (b.Length > a.Length)
        {
            for (int i = shorterLength; i < b.Length; i++)
            {
                result[i] = -b[i];
            }
        }
        return result;
    }

    static int[] MultiplyPolynomials(int[] a, int[] b)
    {
        int[] result = new int[a.Length + b.Length - 1];
        for (int i = 0; i < b.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                result[i + j] += (a[j] * b[i]);
            }
        }
        return result;
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

}