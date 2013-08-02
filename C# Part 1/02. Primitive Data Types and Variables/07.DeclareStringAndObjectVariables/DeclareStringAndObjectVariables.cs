using System;

class DeclareStringAndObjectVariables
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World";
        object concString = helloString + " " + worldString;
        string typeCastedString = (string)concString;
        Console.WriteLine("First string is {0}", helloString);
        Console.WriteLine("Second string is {0}", worldString);
        Console.WriteLine("Object variable is {0}", concString);
        Console.WriteLine("Third string as typecasted object is {0}", typeCastedString);
    }
}
