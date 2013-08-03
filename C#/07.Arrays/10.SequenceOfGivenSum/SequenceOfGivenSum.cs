/* Write a program that finds in given array of integers a sequence of given sum S (if present).
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5} */

using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        int length = 0;
        int givenSum = 0;
        bool isValid;

        do
        {
            Console.Write("Please, enter the sum of the elements: ");
            isValid = int.TryParse(Console.ReadLine(), out givenSum) && givenSum > int.MinValue && givenSum <= int.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        //Array input
        do
        {
            Console.Write("Please, enter the length of the array: ( > 1 ) ");
            isValid = int.TryParse(Console.ReadLine(), out length) && length > 1 && length <= int.MaxValue;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        int[] myArray = new int[length];

        Console.WriteLine();
        Console.WriteLine("Please, enter the elements of the array:");

        for (int i = 0; i < length; i++)
        {
            do
            {
                Console.Write("Ellement {0} = ", i);
                isValid = int.TryParse(Console.ReadLine(), out myArray[i]) && myArray[i] >= int.MinValue && myArray[i] <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter valid number");
                    Console.WriteLine();
                }
            }
            while (!isValid);
        }

        // Search of the sequence
        int sequenceStart = 0;
        int sequeenceEnd = 0;
        bool sequenceFound = false;

        for (int i = 0; i < length && !sequenceFound; i++)
        {
            int tempSum = myArray[i];

            for (int j = i + 1; j < length && !sequenceFound; j++)
            {
                tempSum += myArray[j];
                if (tempSum == givenSum)
                {
                    sequenceStart = i;
                    sequeenceEnd = j;
                    sequenceFound = true;
                }
            }
        }
        
        if (sequenceFound)
        {
            Console.WriteLine("Sequence with given sum is:");
            Console.Write("{");
            for (int i = sequenceStart; i < sequeenceEnd; i++)
            {
                Console.Write("{0}, ", myArray[i]);
            }
            Console.Write(myArray[sequeenceEnd]);
            Console.WriteLine("}");
        }
        else
        {
            Console.WriteLine("There is no sequence with given sum in the array");
        }
    }
}