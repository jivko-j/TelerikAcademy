//Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class DisplayMyAge
{
    static void Main()
    {
        byte currentAge;
        bool isValid;

        do
        {
            Console.Write("Please, enter your age: ");
            string currentAgeStr = Console.ReadLine();
            if (byte.TryParse(currentAgeStr, out currentAge) && (currentAge > 0) && (currentAge < 123))
            {
                isValid = true;
                Console.WriteLine("After 10 years you will be {0} years old", currentAge + 10);
            }
            else
            {
                isValid = false;
                Console.WriteLine("Please, enter correct age!");
                Console.WriteLine();
            }
        }
        while (!isValid);
    }
}