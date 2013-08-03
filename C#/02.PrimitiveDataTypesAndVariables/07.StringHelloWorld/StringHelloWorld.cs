/* Declare two string variables and assign them with “Hello” and “World”.
 * Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
 * Declare a third string variable and initialize it with the value of the object variable (you should perform type casting). */


using System;

class StringHelloWorld
{
    static void Main()
    {
        string stringA = "Hello";
        string stringB = "World";

        object objVariable = stringA + " " + stringB;
        string resultString = objVariable.ToString();
        string resultString1 = (string)objVariable;

        Console.WriteLine("The string with the value of the object variable is: " + resultString);
    }
}