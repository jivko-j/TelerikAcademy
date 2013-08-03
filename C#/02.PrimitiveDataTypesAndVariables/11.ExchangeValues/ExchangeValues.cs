// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ExchangeValues
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;

        Console.WriteLine("Initial  values:  a = {0}  , b = {1}", a, b);

        byte c = a;
        a = b;
        b = c;

        Console.WriteLine("Exchanged values: a = {0} , b = {1}", a, b);
    }
}
