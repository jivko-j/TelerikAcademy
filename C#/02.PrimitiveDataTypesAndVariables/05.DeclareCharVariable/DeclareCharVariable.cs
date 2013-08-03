/* Declare a character variable and assign it with the symbol that has Unicode code 72.
 * Hint: first use the Windows Calculator to find the hexadecimal representation of 72. */

using System;

class DeclareCharVariable
{
    static void Main()
    {
        char symbol72 = '\u0048';
        Console.WriteLine("The character with Unicode code 72 is " + symbol72);
    }
}