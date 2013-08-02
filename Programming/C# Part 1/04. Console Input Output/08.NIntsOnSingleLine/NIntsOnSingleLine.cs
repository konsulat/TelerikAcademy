using System;

class NIntsOnSingleLine
{
    static void Main()
    {
        int n;
        bool isInt;
        Console.Write("Input how many numbers we will print: ");
        isInt = int.TryParse(Console.ReadLine(), out n);
        if (!isInt || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i + 1); 
        }
    }
}
