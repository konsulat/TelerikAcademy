// 03. A company has name, address, phone number, fax number, web site and manager. The manager has first
// name, last name, age and a phone number. Write a program that reads the information about a company and
// its manager and prints them on the console.

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter company phone number: ");
        string companyPhone = Console.ReadLine();

        Console.Write("Enter company FAX number: ");
        string companyFax = Console.ReadLine();

        Console.Write("Enter company web site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();
        string managerName = managerFirstName + " " + managerLastName;

        Console.Write("Enter manager age (integer number): ");
        int managerAge;

        bool isValidAge = int.TryParse(Console.ReadLine(), out managerAge); // Checks for valid input

        if (!isValidAge || managerAge <= 0)
        {
            Console.WriteLine("Invalid input!");
            return; // Exits if not valid integer
        }

        Console.Write("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(new String('#', 30));
        Console.WriteLine("Company information");
        Console.WriteLine(new String('-', 30));
        Console.WriteLine("Name: {0}\nAddress: {1}\nPhone: {2}\nFAX: {3}\nWeb site : {4}",
            companyName, companyAddress, companyPhone, companyFax, companyWebSite);
        Console.WriteLine(new String('*', 30));
        Console.WriteLine("Manager information");
        Console.WriteLine(new String('-', 30));
        Console.WriteLine("Name: {0}\nAge: {1}\nPhone: {2}",
            managerName, managerAge, managerPhone);
        Console.WriteLine(new String('#', 30));
    }
}
