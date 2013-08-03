/* Write a program that creates an array containing all letters from the alphabet (A-Z). 
 * Read a word from the console and print the index of each of its letters in the array. */

using System;

class PrintIndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[28];

        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 65);
        }

        Console.Write("Please, enter a word(Latin leters only)");
        string word = Console.ReadLine().ToUpper();

        for (int letter = 0; letter < word.Length; letter++)
        {
            bool found = false;

            for (int index = 0; index < letters.Length && !found; index++)
            {
                if (letters[index] == word[letter])
                {
                    Console.WriteLine("letter {0} have index {1}", letter, index);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Symbol at position {0} is not a latin letter", letter);
            }
        }
    }
}