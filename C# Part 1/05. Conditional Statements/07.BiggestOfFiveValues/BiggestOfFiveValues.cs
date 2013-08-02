using System;

class BiggestOfFiveValues
{
    static void Main()
    {
        double firstDouble;
        double secondDouble;
        double thirdDouble;
        double fourthDouble;
        double fifthDouble;
        bool isDouble;
        Console.Write("Type first real number: ");
        isDouble = double.TryParse(Console.ReadLine(), out firstDouble);
        if (!isDouble)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Console.Write("Type second real number: ");
        isDouble = double.TryParse(Console.ReadLine(), out secondDouble);
        if (!isDouble)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Console.Write("Type third real number: ");
        isDouble = double.TryParse(Console.ReadLine(), out thirdDouble);
        if (!isDouble)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Console.Write("Type fourth real number: ");
        isDouble = double.TryParse(Console.ReadLine(), out fourthDouble);
        if (!isDouble)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Console.Write("Type fifth real number: ");
        isDouble = double.TryParse(Console.ReadLine(), out fifthDouble);
        if (!isDouble)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        double biggestDouble = firstDouble;
        if (secondDouble > biggestDouble)
        {
            biggestDouble = secondDouble;
        }
        if (thirdDouble > biggestDouble)
        {
            biggestDouble = thirdDouble;
        }
        if (fourthDouble > biggestDouble)
        {
            biggestDouble = fourthDouble;
        }
        if (fifthDouble > biggestDouble)
        {
            biggestDouble = fifthDouble;
        }
        Console.WriteLine("The greatest of given five values is {0}", biggestDouble);
    }
}
