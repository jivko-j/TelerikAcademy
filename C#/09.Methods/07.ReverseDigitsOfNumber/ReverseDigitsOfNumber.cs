// Write a method that reverses the digits of given decimal number. Example: 256  652

using System;
using System.Text;

class ReverseDigitsOfNumber
{
    static void Main()
    {
        decimal inputNumber = InputNumber("Please, enter decimal number: ", decimal.MinValue, decimal.MaxValue);

        decimal outputNumber = ReverseDigits(inputNumber);

        Console.WriteLine("Number with reversed digits is: {0}", outputNumber);
    }

    static decimal InputNumber(string message, decimal min, decimal max)
    {
        bool isValid;
        decimal output;
        do
        {
            Console.Write(message);
            isValid = decimal.TryParse(Console.ReadLine(), out output) && output >= min && output <= max;
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter correct number");
                Console.WriteLine();
            }
        } while (!isValid);
        return output;
    }

    static decimal ReverseDigits(decimal inputNumber)
    {
        string numberAsString = inputNumber.ToString();
        StringBuilder newSring = new StringBuilder();

        for (int i = numberAsString.Length - 1; i >= 0 ; i--)
        {
            newSring.Append(numberAsString[i]);
        }

        return decimal.Parse(newSring.ToString());
    }
}