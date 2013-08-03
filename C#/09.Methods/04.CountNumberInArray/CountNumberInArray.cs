/* Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is working correctly. */

using System;

namespace CountNumberInArray
{
    public class CountNumberInArray
    {
        static void Main()
        {
            int[] myArray = { 8, 5, 7, 2, 1, 5, 8, 2, 7, 1, 3, 5, 4, 9, 8, 9, 0, 1, 7 };

            int number = InputNumber("Please, enter searched number: ", int.MinValue, int.MaxValue);

            int countNumber = CountNumber(number, myArray);

            if (countNumber > 0)
            {
                Console.WriteLine("Number {0} appears {1} times in the array", number, countNumber);
            }
            else
            {
                Console.WriteLine("Number {0} was not found in the array", number);
            }
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

        public static int CountNumber(int searchedNumber, int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchedNumber)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}