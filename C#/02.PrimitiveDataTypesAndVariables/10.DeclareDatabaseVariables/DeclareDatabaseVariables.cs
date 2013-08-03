/* A marketing firm wants to keep record of its employees.
 * Each record would have the following characteristics –
 * first name, family name, age, gender (m or f), ID number,
 * unique employee number (27560000 to 27569999).
 * Declare the variables needed to keep the information for a single employee
 * using appropriate data types and descriptive names. */

using System;

class DeclareDatabaseVariables
{
    static void Main()
    {
        string firstName = "Jim";
        string familyName = "Smith";
        byte age = 23;
        char gender = 'm';
        uint idNo = 1234567890;
        uint employeeNo = 27560102;

        Console.WriteLine("Employee:");
        Console.WriteLine(new string('-', 25));
        Console.WriteLine("First Name  - " + firstName);
        Console.WriteLine("Last Name   - " + familyName);
        Console.WriteLine("Age         - " + age);
        Console.WriteLine("Gender      - " + gender);
        Console.WriteLine("ID number   - " + idNo);
        Console.WriteLine("Employee No - " + employeeNo);
        Console.WriteLine(new string('-', 25));
    }
}
