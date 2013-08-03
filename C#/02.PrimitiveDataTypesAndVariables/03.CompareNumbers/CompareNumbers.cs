/* Write a program that safely compares floating-point numbers with precision of 0.000001. 
 * Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true */

using System;

class CompareNumbers
{
    static void Main()
    {
        double[] a = new double[4];
        double[] b = new double[4];

        a[0] = 5.3d;
        b[0] = 6.01d;

        a[1] = 5.000001d;
        b[1] = 5.000002d;

        a[2] = 5.0000001d;
        b[2] = 5.0000003d;

        a[3] = 123456789.000001d;
        b[3] = 123456789.000003d;

        double deltaAB;
        bool equal;

        for (byte i = 0; i < 4; i++)
        {
            deltaAB = Math.Abs(a[i] - b[i]);
            equal = (deltaAB <= 0.000001);
            Console.WriteLine("Numbers");
            Console.WriteLine(a[i]);
            Console.WriteLine(b[i]);
            Console.WriteLine("are equal with precision of 0.000001? - " + equal);
            Console.WriteLine();
        }
    }
}