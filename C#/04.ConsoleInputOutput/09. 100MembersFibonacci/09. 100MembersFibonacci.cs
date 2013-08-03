/* Write a program to print the first 100 members of the sequence of Fibonacci:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */

using System;

class MembersFibonacci
{
    static void Main()
    {
        decimal memberA = 0;
        decimal memberB = 1;
        decimal newMember;

        Console.WriteLine("{0,22}", memberA);
        Console.WriteLine("{0,22}", memberB);

        for (byte i = 3; i < 101; i++)
        {
            newMember = memberA + memberB;
            Console.WriteLine("{0,22}", newMember);
            memberA = memberB;
            memberB = newMember;
        }
    }
}