/* A company has name, address, phone number, fax number, web site and manager.
 * The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager
 * and prints them on the console. */

using System;

class CompanyInformation
{
    static void Main()
    {
        bool isValid;
        string inString;
        string companyName;
        string companyAddress;
        string companyPhoneNo;
        string companyFaxNo;
        string companyWebSite;
        string managerFirstName;
        string managerLastName;
        sbyte managerAge;
        string managerPhoneNo;

        Console.WriteLine("Please, enter following information about the company:");
        Console.Write("Company name: ");
        companyName = Console.ReadLine();
        Console.Write("     Address: ");
        companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        companyPhoneNo = Console.ReadLine();
        Console.Write("  Fax number: ");
        companyFaxNo = Console.ReadLine();
        Console.Write("    WEB site: ");
        companyWebSite = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Company manager:");
        Console.Write("  First name: ");
        managerFirstName = Console.ReadLine();
        Console.Write("   Last name: ");
        managerLastName = Console.ReadLine();
        Console.Write("Phone number: ");
        managerPhoneNo = Console.ReadLine();

        do
        {
            Console.Write("        Age: ");
            inString = Console.ReadLine();
            isValid = sbyte.TryParse(inString, out managerAge) && (managerAge < 123);
            if (!isValid)
            {
                Console.WriteLine();
                Console.WriteLine("Please, enter valid age!");
                Console.WriteLine();
            }
        }
        while (!isValid);

        Console.WriteLine();
        Console.WriteLine(new string('-', 45));
        Console.WriteLine("Company information:");
        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("     Address: {0}", companyAddress);
        Console.WriteLine("Phone number: {0}", companyPhoneNo);
        Console.WriteLine("  Fax number: {0}", companyFaxNo);
        Console.WriteLine("    WEB site: {0}", companyWebSite);
        Console.WriteLine();
        Console.WriteLine("Company manager:");
        Console.WriteLine("  First name: {0}", managerFirstName);
        Console.WriteLine("   Last name: {0}", managerLastName);
        Console.WriteLine("Phone number: {0}", managerPhoneNo);
        Console.WriteLine(new string('-', 45));
    }
}