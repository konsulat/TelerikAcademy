using System;

class ShowSignOfProduct
{
    static void Main()
    {
        double firstDouble;
        double secondDouble;
        double thirdDouble;
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

        if (firstDouble == 0 || secondDouble == 0 || thirdDouble == 0)
        {
            Console.WriteLine("The sign of the product of the three real numbers is neutral (the product is 0)");
        }
        else if (firstDouble > 0)
        {
            if (secondDouble > 0 && thirdDouble > 0)
            {
                Console.WriteLine("The sign of the product of the three real numbers is plus (+)");
            }
            else if (secondDouble > 0 ^ thirdDouble > 0)
            {
                Console.WriteLine("The sign of the product of the three real numbers is minus (-)");
            }
            else
            {
                Console.WriteLine("The sign of the product of the three real numbers is plus (+)");
            }
        }
        else if (secondDouble > 0)
        {
            if (firstDouble > 0 && thirdDouble > 0)
            {
                Console.WriteLine("The sign of the product of the three real numbers is plus (+)");
            }
            else if (firstDouble > 0 ^ thirdDouble > 0)
            {
                Console.WriteLine("The sign of the product of the three real numbers is minus (-)");
            }
            else
            {
                Console.WriteLine("The sign of the product of the three real numbers is plus (+)");
            }
        }
        else if (thirdDouble > 0)
        {
            if (firstDouble > 0 && secondDouble > 0)
            {
                Console.WriteLine("The sign of the product of the three real numbers is plus (+)");
            }
            else if (firstDouble > 0 ^ secondDouble > 0)
            {
                Console.WriteLine("The sign of the product of the three real numbers is minus (-)");
            }
            else
            {
                Console.WriteLine("The sign of the product of the three real numbers is plus (+)");
            }
        }
        else
        {
            Console.WriteLine("The sign of the product of the three real numbers is minus (-)");
        }
    }
}
