/* Declare a boolean variable called isFemale
 * and assign an appropriate value corresponding to your gender. */

using System;

class DeclareBoolVariable
{
    static void Main()
    {

        bool isFemale;
        bool isValid;

        do
        {
            Console.Write("Please, enter your gender (male / female): ");
            string inGender = Console.ReadLine().ToLower();
            if (inGender == "female" || inGender == "male")
            {
                isValid = true;
                isFemale = (inGender == "female");
                Console.WriteLine();
                Console.WriteLine("You're female? - " + isFemale);
                Console.WriteLine();
            }
            else
            {
                isValid = false;
                Console.WriteLine();
                Console.WriteLine("Please, enter correct answer");
                Console.WriteLine();
            }
        }
        while (!isValid);
    }
}