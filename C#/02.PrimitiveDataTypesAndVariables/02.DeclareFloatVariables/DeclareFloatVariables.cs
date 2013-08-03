/* Which of the following values can be assigned to a variable of type float
 * and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? */

using System;

class DeclareFloatVariables
{
    static void Main()
    {
        double firstFloatNumber = 34.567839023d;
        float secondFloatNumber = 12.345f;
        double thirdFloatNumber = 8923.1234857d;
        float fourthFloatNumber = 3456.091f;

        Console.WriteLine("{0,12} - double", firstFloatNumber);
        Console.WriteLine("{0,12} - float", secondFloatNumber);
        Console.WriteLine("{0,12} - double", thirdFloatNumber);
        Console.WriteLine("{0,12} - float", fourthFloatNumber);
    }
}