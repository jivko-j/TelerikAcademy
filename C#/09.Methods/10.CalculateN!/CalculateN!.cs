/* Write a program to calculate n! for each n in the range [1..100].
 * Hint: Implement first a method that multiplies a number
 * represented as array of digits by given integer number. */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        byte[] nFact = { 1 };

        int n = InputNumber("Please, enter N (1-100)", 1, 100);

        for (int i = 1; i <= n; i++)
        {
            nFact = Multiply(nFact, ToArrayOfDigits(i));
        }

        Console.Write("N! is: ");
        for (int i = nFact.Length - 1; i >= 0; i--)
        {
            Console.Write(nFact[i]);
        }
        Console.WriteLine();
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

    static byte[] Multiply(byte[] multiplicant, byte[] multiplier)
    {
        // Multiplies two big numbers, represented as arrays of digits
        List<byte> result = new List<byte>();
        List<byte> tempResult;
        byte toAdd = 0;
        byte digitProduct = 0;

        for (int i = 0; i < multiplier.Length; i++)
        {
            tempResult = new List<byte>();
            toAdd = 0;
            digitProduct = 0;
            // Add zeros at end coresponding to digit position in multiplier
            for (int pos = 0; pos < i; pos++)
            {
                tempResult.Add(0);
            }
            
            // Multiply multiplicant with a digit of multiplier
            for (int j = 0; j < multiplicant.Length; j++)
            {
                digitProduct = (byte)(multiplier[i] * multiplicant[j] + toAdd);
                tempResult.Add((byte)(digitProduct % 10));
                toAdd = (byte)(digitProduct / 10);
            }
            if (toAdd != 0)
            {
                tempResult.Add(toAdd);
            }

            result = Sum(result, tempResult);
        }
        return result.ToArray();
    }

    static List<byte> Sum(List<byte> a, List<byte> b)
    {
        //Sum two big numbers, represented as lists of digits
        List<byte> result = new List<byte>();
        byte toAdd = 0;
        byte digitSum = 0;
        int shorterlength = Math.Min(a.Count, b.Count);

        //Sum to the length of shortest number
        for (int i = 0; i < shorterlength; i++)
        {
            digitSum = (byte)(a[i] + b[i] + toAdd);
            result.Add((byte)(digitSum % 10));
            toAdd = (byte)(digitSum / 10);
        }

        // If one of the numbers is longer
        if (a.Count > b.Count)
        {
            for (int i = shorterlength; i < a.Count; i++)
            {
                digitSum = (byte)(a[i] + toAdd);
                result.Add((byte)(digitSum % 10));
                toAdd = (byte)(digitSum / 10);
            }
        }
        else if (b.Count > a.Count)
        {
            for (int i = shorterlength; i < b.Count; i++)
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

        return result;
    }

    static byte[] ToArrayOfDigits(int inNumber)
    {
        // Convert an integer to array of digits
        string inString = inNumber.ToString();
        int length = inString.Length;
        byte[] number = new byte[length];
        for (int i = 0; i < length; i++)
        {
            number[i] = byte.Parse((inString[inString.Length - i - 1]).ToString());
        }
        return number;
    }
}