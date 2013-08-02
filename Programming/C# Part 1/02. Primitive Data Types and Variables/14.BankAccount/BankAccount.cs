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
        string IBAN = "BG 08 UBBS 9200 1567 6754 17";
        string BIC = "UBBSBGSF";
        long firstCreditCard = 4042678716547645L;
        long secondCreditCard = 567890866546347L;
        long thirdCreditCard = 4890564787431323L;

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Account holder:");
        Console.WriteLine(holderName);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.WriteLine("BIC: {0}", BIC);
        Console.WriteLine("Balance: {0} EUR", balance);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Credit Cards:");
        Console.WriteLine("No: {0} ", firstCreditCard);
        Console.WriteLine("No: {0} ", secondCreditCard);
        Console.WriteLine("No: {0} ", thirdCreditCard);
        Console.WriteLine(new string('-', 30));
    }
}
