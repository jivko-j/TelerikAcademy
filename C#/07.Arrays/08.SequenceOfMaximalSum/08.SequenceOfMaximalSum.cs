/* Write a program that finds the sequence of maximal sum in given array.
 * Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4} */

using System;

class SequenceOfMaximalSum
    {
        static void Main()
        {
            int length = 0;
            bool isValid;

            //Array input
            do
            {
                Console.Write("Please, enter the length of the array: ( > 2 ) ");
                isValid = int.TryParse(Console.ReadLine(), out length) && length > 2 && length <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter valid number");
                    Console.WriteLine();
                }
            }
            while (!isValid);

            double[] myArray = new double[length];

            Console.WriteLine();
            Console.WriteLine("Please, enter the elements of the array:");

            for (int i = 0; i < length; i++)
            {
                do
                {
                    Console.Write("Ellement {0} = ", i);
                    isValid = double.TryParse(Console.ReadLine(), out myArray[i]) && myArray[i] >= double.MinValue && myArray[i] <= double.MaxValue;
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
            double maxSum = double.MinValue;
            int sequenceStart = 0;
            int sequeenceEnd = 0;

            for (int i = 0; i < length; i++)
            {
                double tempSum = myArray[i];

                for (int j = i + 1; j < length; j++)
                {
                    tempSum += myArray[j];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        sequenceStart = i;
                        sequeenceEnd = j;
                    }
                }
            }
            Console.WriteLine("Sequence of maximal sum is:");
            Console.Write("{");
            for (int i = sequenceStart; i < sequeenceEnd; i++)
            {
                Console.Write("{0}, ", myArray[i]);
                            }
            Console.Write(myArray[sequeenceEnd]);
            Console.WriteLine("}");
        }
    }