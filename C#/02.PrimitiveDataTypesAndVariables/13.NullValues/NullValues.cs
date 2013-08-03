/* Create a program that assigns null values to an integer and to double variables.
 * Try to print them on the console, try to add some values or the null literal to them and see the result. */

using System;

class NullValues
{
    static void Main()
    {
        int? var1 = null;
        double? var2 = null;

        Console.WriteLine("After initialisation");
        Console.WriteLine("First variable  - Has value - {0} , the value is ->{1}<-", var1.HasValue, var1);
        Console.WriteLine("Second variable - Has value - {0} , the value is ->{1}<-", var2.HasValue, var2);
        Console.WriteLine();

        var1 = var1 + 5;
        var2 = var2 + 77;

        Console.WriteLine("After adding some value");
        Console.WriteLine("First variable  - Has value - {0} , the value is ->{1}<-", var1.HasValue, var1);
        Console.WriteLine("Second variable - Has value - {0} , the value is ->{1}<-", var2.HasValue, var2);
        Console.WriteLine();

        var2 = var1 + var2;

        Console.WriteLine("After adding first variable to second variable");
        Console.WriteLine("Second variable - Has value - {0} , the value is ->{1}<-", var2.HasValue, var2);
    }
}
