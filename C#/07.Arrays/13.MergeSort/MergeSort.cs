/* Write a program that sorts an array of integers using the merge sort algorithm
 * (find it in Wikipedia). */

using System;

    class MergeSort
    {

        static public void DoMerge(int[] input, int left, int mid, int right)
        {
            // This method compares elements on the left and right part of the subarray
            // and sorts them (merge two parts)

            int leftEnd, numElements, tempPosition;

            leftEnd = mid - 1;
            tempPosition = 0;
            numElements = right - left + 1;
            int[] temp = new int[numElements];

            // Enable next row to see range of elements compared at every step
            //Console.WriteLine("{0} - {1}", left, right);

            // Copy in sorted way elements in temp array until end of one part of the subarray
            while ((left <= leftEnd) && (mid <= right))
            {
                if (input[left] <= input[mid])
                {
                    temp[tempPosition++] = input[left++];
                }
                else
                {
                    temp[tempPosition++] = input[mid++];
                }
            }

            // Copy remaining elements (if left) from two parts of the subarray
            while (left <= leftEnd)
            {
                temp[tempPosition++] = input[left++];
            }

            while (mid <= right)
            {
                temp[tempPosition++] = input[mid++];
            }

            // Copy sotred elements back to the array
            for (int i = numElements - 1; i >= 0; i--)
            {
                input[right] = temp[i];
                right--;
            }
        }

        static public void MergeSortRecursive(int[] input, int left, int right)
        {
            // This method split array into two parts recursively and send parts to be merged
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortRecursive(input, left, mid);
                MergeSortRecursive(input, (mid + 1), right);
                DoMerge(input, left, (mid + 1), right);
            }
        }


        static void Main()
        {
            int[] myArray = { 3, 8, 5, -4,  5, 2, 1, 11, 6, 4, -1, 0, 17, 13, 3, -7 };
            int length = myArray.Length;

            MergeSortRecursive(myArray, 0, length - 1);

            Console.WriteLine("Sorted array is:");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }