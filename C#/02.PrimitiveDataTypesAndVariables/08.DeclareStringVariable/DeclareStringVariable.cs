/* Declare two string variables and assign them with following value:
 * The "use" of quotations causes difficulties.
 * Do the above in two different ways: with and without using quoted strings. */

using System;

class DeclareStringVariable
{
    static void Main()
    {
        string quotedString = "The \"use\" of quotations causes difficulties.";
        string verbatimString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quotedString);
        Console.WriteLine(verbatimString);
    }
}