// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateSum
{
    static void Main()
    {
        float oldSum = 1;
        float newSum;
        uint i = 2;
        float difference;
        sbyte sign = 1;

        do
        {
            newSum = oldSum + sign * 1.0f / i;
            difference = Math.Abs(newSum - oldSum);
            Console.WriteLine("After adding {0,4} member sum is {1:N10}, difference is {2:N10}", i, newSum, difference);
            i++;
            sign *= -1;
            oldSum = newSum;
        }
        while (difference > 0.001);
    }
}