//Write a program that compares two char arrays lexicographically (letter by letter).

/*  A string s precedes a string t in lexicographic order if
    s is a prefix of t, or
    if c and d are respectively the first character of s and t in which s and t differ,
   then c precedes d in character order.

Note: For the characters that are alphabetical letters, the character order coincides with
   the alphabetical order. Digits precede letters, and uppercase letters precede lowercase ones. */

using System;

class CompareLexicographically
{
    static void Main()
    {
        Console.Write("Please, enter first string: ");
        string firstString = Console.ReadLine();
        Console.Write("Please, enter second string: ");
        string secondString = Console.ReadLine();

        // CSharp String Compare function:
        // int comparisonResult = string.Compare(firstString, secondString);

        char[] firstAray = firstString.ToCharArray();
        char[] secondArray = secondString.ToCharArray();
        int comparisonResult = 0;
        int length = Math.Min(firstAray.Length, secondArray.Length);

        // Comparison letter by letter
        for (int i = 0; i < length; i++)
        {
            if (firstAray[i] < secondArray[i])
            {
                comparisonResult = -1;
                break;
            }
            else if (firstAray[i] > secondArray[i])
            {
                comparisonResult = 1;
                break;
            }
        }

        // If strings are equal to the length of the shorter string, compare their length
        if (comparisonResult == 0)
        {
            if (firstAray.Length < secondArray.Length)
            {
                comparisonResult = -1;
            }
            else if (firstAray.Length > secondArray.Length)
            {
                comparisonResult = 1;
            }
        }
        switch (comparisonResult)
        {
            case -1:
                Console.WriteLine("First string preceds second string");
                break;
            case 1:
                Console.WriteLine("Second string preceds first string");
                break;
            case 0:
                Console.WriteLine("Two strings are equal");
                break;
        }
    }
}