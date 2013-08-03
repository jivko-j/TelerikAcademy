/* Write a method that adds two positive integer numbers represented as arrays of digits
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.  */

using System;
using System.Collections.Generic;

class SumTwoBigIntegers
{
    static void Main()
    {
        //As entering a string is easily than an array of digits
        string firstNumberAsString = "31404024012340128340125801241285012";
        string secondMumberAsString = "98092874807918237498709123409709712349";

        //string firstNumberAsString = "314";
        //string secondMumberAsString = "9801";

        //Convert number to array of digits
        byte[] firstNumber = new byte[firstNumberAsString.Length];
        byte[] secondNumber = new byte[secondMumberAsString.Length];

        firstNumber = StringToArrayDigits(firstNumberAsString);
        secondNumber = StringToArrayDigits(secondMumberAsString);

        byte[] result;

        result = Sum(firstNumber, secondNumber);

        Console.WriteLine("Result of the sum is:");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }

    static byte[] StringToArrayDigits(string inString)
    {
        int length = inString.Length;
        byte[] number = new byte[length];
        for (int i = 0; i < length; i++)
        {
            number[i] = byte.Parse((inString[inString.Length - i - 1]).ToString());
        }
        return number;
    }

    static byte[] Sum(byte[] a, byte[] b)
    {
        //Result may be a digit longer than longer number, so I use List
        List<byte> result = new List<byte>();
        byte toAdd = 0;
        byte digitSum = 0;
        int shorterlength = Math.Min(a.Length, b.Length);
        
        //Sum to the length of shortest number
        for (int i = 0; i < shorterlength; i++)
        {
            digitSum = (byte)(a[i] + b[i] + toAdd);
            result.Add((byte)(digitSum % 10));
            toAdd = (byte)(digitSum / 10);
        }
        
        // If one of the numbers is longer
        if (a.Length > b.Length)
        {
            for (int i = shorterlength; i < a.Length; i++)
            {
                digitSum = (byte)(a[i] + toAdd);
                result.Add((byte)(digitSum % 10));
                toAdd = (byte)(digitSum / 10);
            }
        }
        else if (b.Length > a.Length)
        {
            for (int i = shorterlength; i < b.Length; i++)
            {
                digitSum = (byte)(b[i] + toAdd);
                result.Add((byte)(digitSum % 10));
                toAdd = (byte)(digitSum / 10);
            }
        }
        
        if (toAdd != 0)
        {
            result.Add(toAdd);
        }

        return result.ToArray();
    }
}