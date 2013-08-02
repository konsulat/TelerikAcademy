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
        bool isValidAge = int.TryParse(Console.ReadLine(), out managerAge);
        if (!isValidAge || managerAge <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Console.Write("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(new String('#', 30));
        Console.WriteLine("Company information");
        Console.WriteLine(new String('-', 30));
        Console.WriteLine("Name: {0}\nAddress: {1}\nPhone: {2}\nFAX: {3}",
            companyName, companyAddress, companyPhone, companyFax);
        Console.WriteLine(new String('*', 30));
        Console.WriteLine("Manager information");
        Console.WriteLine(new String('-', 30));
        Console.WriteLine("Name: {0}\nAge: {1}\nPhone: {2}",
            managerName, managerAge, managerPhone);
        Console.WriteLine(new String('#', 30));
    }
}
