/* Declare five variables choosing for each of them the most appropriate of the types
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
 * 52130, -115, 4825932, 97, -10000. */

using System;

class DeclareIntVariables
{
    static void Main()
    {
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        uint thirdNumber = 4825932u;
        byte fourthNumber = 97;
        short fifthNumber = -10000;

        Console.WriteLine("{0,8} - ushort", firstNumber);
        Console.WriteLine("{0,8} - sbyte", secondNumber);
        Console.WriteLine("{0,8} - uint", thirdNumber);
        Console.WriteLine("{0,8} - byte", fourthNumber);
        Console.WriteLine("{0,8} - short", fifthNumber);
    }
}
