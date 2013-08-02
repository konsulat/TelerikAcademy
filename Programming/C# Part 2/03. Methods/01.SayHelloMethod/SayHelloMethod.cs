using System;

class SayHelloMethod
{
    static void SayHello()
    {
        Console.WriteLine("Type your name, please");
        string name = Console.ReadLine();
        Console.WriteLine("Hello {0}!", name);
    }

    static void Main()
    {
        SayHello();
    }
}
