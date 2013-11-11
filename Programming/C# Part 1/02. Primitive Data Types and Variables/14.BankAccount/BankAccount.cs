// 14. A bank account has a holder name (first name, middle name and last name), available amount
// of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the
// account. Declare the variables needed to keep the information for a single bank account using
// the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Ivanov";
        string familyName = "Peshev";
        string holderName = firstName + " " + middleName + " " + familyName;
        decimal balance = 1291.34M;
        string bankName = "UniCredit Bulbank";
        string iban = "BG 08 UBBS 9200 1567 6754 17";
        string bic = "UBBSBGSF";
        string firstCreditCard = "4042 6787 1654 7645";
        string secondCreditCard = "5678 9086 6546 3474";
        string thirdCreditCard = "4890 5647 8743 1323";

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Account holder:");
        Console.WriteLine(holderName);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("BIC: {0}", bic);
        Console.WriteLine("Balance: {0} EUR", balance);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Credit Cards:");
        Console.WriteLine("No: {0} ", firstCreditCard);
        Console.WriteLine("No: {0} ", secondCreditCard);
        Console.WriteLine("No: {0} ", thirdCreditCard);
        Console.WriteLine(new string('-', 30));
    }
}
