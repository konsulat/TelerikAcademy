using System;

class MarketingFirmRecord
{
    static void Main()
    {
        string firstName = "Pesho"; // Not a real first name
        string familyName = "Peshev"; // Not a real family name
        byte age = 30;
        char gender = 'm';
        uint idNumber = 27567391;
        Console.WriteLine("Record with ID number {0}", idNumber);
        Console.WriteLine("First name: {0}, Family: {1}, Age: {2}, Gender: {3}", firstName, familyName, age, gender);
    }
}
