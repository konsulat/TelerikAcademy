using System;

class AlphabetArray
{
    static void Main()
    {
        Console.WriteLine("Write a word, please (using only capital letters A-Z)");
        string word = Console.ReadLine();

        Console.WriteLine("Index of each letter:");
        foreach (char letter in word)
        {
            int index = (int)letter - (int)'A';
            Console.Write(index + " ");
        }
        Console.WriteLine();
    }
}
