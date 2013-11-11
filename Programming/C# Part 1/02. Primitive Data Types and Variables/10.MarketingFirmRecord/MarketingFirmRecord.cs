// 10. A marketing firm wants to keep record of its employees. Each record would have the following
// characteristics – first name, family name, age, gender (m or f), ID number, unique employee number
// (27560000 to 27569999). Declare the variables needed to keep the information for a single employee
// using appropriate data types and descriptive names.

using System;

class MarketingFirmRecord
{
    static void Main()
    {
        string firstName = "Pesho"; // Not a real first name
        string familyName = "Peshev"; // Not a real family name
        byte age = 30;
        char gender = 'm';
        uint id = 3;
        uint uniqueNumber = 27569999;

        Console.WriteLine("ID: {0}\nUnique employee number: {1}\nName: {2} {3}\nAge: {4}, Gender: {5}",
            id, uniqueNumber, firstName, familyName, age, gender);
    }
}
