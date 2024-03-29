﻿/* Write a method that asks the user for his name and prints “Hello, <name>” 
 * (for example, “Hello, Peter!”). Write a program to test this method. */

using System;

namespace PrintName01
{
    public class PrintYourName
    {
        static void Main()
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            PrintName(name);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}