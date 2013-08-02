using System;
using System.Collections.Generic;
using System.Linq;

class ArraySortedByElementsLength
{
    static void Main()
    {
        string[] unsorted = { "1", "ab", "rty", "r", "df", "bgdf", "fghtujk", "yht" };
        Console.WriteLine("Unsorted array");
        Console.Write(string.Join(", ", unsorted));
        Console.WriteLine();
        List<string> sorted = new List<string>();

        foreach (string str in unsorted.OrderBy(strings => strings.Length))
        {
            sorted.Add(str);
        }

        Console.WriteLine("Sorted array");
        Console.Write(string.Join(", ", sorted));
        Console.WriteLine();
    }
}
