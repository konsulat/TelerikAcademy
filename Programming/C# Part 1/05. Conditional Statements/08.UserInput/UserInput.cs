// 08. Write a program that, depending on the user's choice inputs int, double or string variable.
// If the variable is integer or double, increases it with 1. If the variable is string, appends "*"
// at its end. The program must show the value of that variable as a console output. Use switch
// statement.

using System;

class UserInput
{
    static void Main()
    {
        bool result = false;

        Console.Write("Type 1 for int, 2 for double or 3 for string: ");
        string inputStr = Console.ReadLine();

        if (inputStr.Length != 1)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        char inputChar = char.Parse(inputStr);

        switch (inputChar)
        {
            case '1':
                int intInput;

                Console.Write("Enter integer value: ");

                result = int.TryParse(Console.ReadLine(), out intInput);

                if (!result)
                {
                    Console.WriteLine("Invalid integer!");
                    return;
                }

                Console.WriteLine("Your integer increased with 1: {0}", intInput + 1);
                break;
            case '2':
                double doubleInput;

                Console.Write("Enter real value: ");

                result = double.TryParse(Console.ReadLine(), out doubleInput);

                if (!result)
                {
                    Console.WriteLine("Invalid real number!");
                    return;
                }

                Console.WriteLine("Your integer increased with 1: {0}", doubleInput + 1);
                break;
            case '3':
                Console.Write("Enter a string: ");
                string stringInput = Console.ReadLine();

                Console.WriteLine("Your string appended with \"*\" at its end: {0}", stringInput + "*");
                break;
            default:
                Console.WriteLine("Wrong choise!");
                break;
        }
    }
}
