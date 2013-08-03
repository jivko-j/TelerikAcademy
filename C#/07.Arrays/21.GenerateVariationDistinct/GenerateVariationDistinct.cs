/* Write a program that reads two numbers N and K and generates all the combinations
 * of K distinct elements from the set [1..N]. Example:
	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5} */

using System;

class GenerateVariationDistinct
    {
        static void GenerateVariation(int[] variation, int index, int n)
        {
            if (index < variation.Length)
            {
                int start;
                if (index > 0)
                {
                    start = variation[index - 1] + 1;
                }
                else
                {
                    start = 1;
                }
                for (int i = start; i <= n; i++)
                {
                    variation[index] = i;
                    GenerateVariation(variation, index + 1, n);
                }
            }
            else
            {
                PrintVariation(variation);
            }
        }

        static void PrintVariation(int[] variation)
        {
            Console.Write("{");
            for (int i = 0; i < variation.Length - 1; i++)
            {
                Console.Write("{0},", variation[i]);
            }
            Console.Write("{0}", variation[variation.Length - 1]);
            Console.WriteLine("}");
        }

        static void Main()
        {
            bool isValid = false;
            int n, k;

            do
            {
                Console.Write("Please, enter N (N > 1): ");
                isValid = int.TryParse(Console.ReadLine(), out n) && n > 1 && n <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }
            } while (!isValid);

            do
            {
                Console.Write("Please, enter K (K > 1): ");
                isValid = int.TryParse(Console.ReadLine(), out k) && k > 1 && k <= int.MaxValue;
                if (!isValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter correct number");
                    Console.WriteLine();
                }

            } while (!isValid);

            int[] variation = new int[k];
            GenerateVariation(variation, 0, n);
        }
    }