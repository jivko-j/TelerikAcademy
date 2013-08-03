/* Find online more information about ASCII (American Standard Code for Information Interchange)
 * and write a program that prints the entire ASCII table of characters on the console. */

using System;

class PrintACSII
{
    static void Main()
    {
        for (byte code = 0; code < 127; code++) //Original ASCII table is 7 bit, have 128 symbols.
        {
            char symbol = (char)code;
            Console.WriteLine("ASCII code {0} -> symbol {1}", code, symbol);
        }
    }
}