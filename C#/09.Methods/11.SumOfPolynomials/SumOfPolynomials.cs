/* Write a method that adds two polynomials. Represent them as arrays of their coefficients
 * as in the example below: x2 + 5 = 1x2 + 0x + 5  |5|0|1| */

using System;

class SumOfPolynomials
{
    static void Main()
    {
        int[] coeffA = { 3, -4, 5, 6, 9 };
        int[] coeffB = { 7, 3, -5, 2 };

        int[] result = SumPolynomials(coeffA, coeffB);

        Console.WriteLine("The result polynominal have coefficients:");
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