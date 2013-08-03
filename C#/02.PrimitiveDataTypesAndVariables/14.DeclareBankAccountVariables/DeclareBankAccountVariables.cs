/* A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, BIC code
 * and 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank account
 * using the appropriate data types and descriptive names. */

using System;

class DeclareBankAccountVariables
{
    static void Main()
    {
        string firstName = "Jim";
        string middleName = "Jon";
        string lastName = "Jones";
        decimal balance = 3256789.12m;
        string bankName = "Central Bank";
        string iban = "UN11CENB12345678MA90PL";
        string bic = "BRBFCENB";
        ulong cardNo1 = 4587258612583657u;
        ulong cardNo2 = 5646846879798789u;
        ulong cardNo3 = 8443246546464968u;

        Console.WriteLine(new string('-', 35));
        Console.WriteLine("Account info");
        Console.WriteLine(new string('-', 35));
        Console.WriteLine("Holder name: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine();
        Console.WriteLine("Ballance: {0:N} USD", balance);
        Console.WriteLine();
        Console.WriteLine("Bank:  {0}", bankName);
        Console.WriteLine("IBAN:  {0}", iban);
        Console.WriteLine("BIC:   {0}", bic);
        Console.WriteLine();
        Console.WriteLine("Credit card numbers:");
        Console.WriteLine("Card 1:  {0}", cardNo1);
        Console.WriteLine("Card 2:  {0}", cardNo2);
        Console.WriteLine("Card 3:  {0}", cardNo3);
        Console.WriteLine(new string('-', 35));
    }
}