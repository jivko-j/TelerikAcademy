/* Write an if statement that examines two integer variables and exchanges
 * their values if the first one is greater than the second one. */


using System;

class ExamenTwoVariables
{
    static void Main()
    {
        bool isValid;
        string inString;
        int firstVariable;
        int secondVariable;

        do
        {
            Console.Write("Please, enter first number:");
            inString = Console.ReadLine();
            isValid = int.TryParse(inString, out firstVariable) && (firstVariable >= int.MinValue) && (firstVariable <= int.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        do
        {
            Console.Write("Please, enter second number:");
            inString = Console.ReadLine();
            isValid = int.TryParse(inString, out secondVariable) && (secondVariable >= int.MinValue) && (secondVariable <= int.MaxValue);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        }
        while (!isValid);

        if (firstVariable > secondVariable)
        {
            int tempVariable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = tempVariable;
            Console.WriteLine("First variable was greater than second variable and their values were exchanged");
        }
        Console.WriteLine("Now first variable is {0} and second variable is {1}", firstVariable, secondVariable);
    }
}