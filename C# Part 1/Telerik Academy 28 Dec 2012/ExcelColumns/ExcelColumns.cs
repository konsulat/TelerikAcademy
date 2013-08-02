using System;

class ExcelColumns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long result = 0;
        for (int i = 0; i < n; i++)
        {
            result = (result + Console.ReadLine()[0] - 64) * 26;
        }
        Console.WriteLine(result / 26);
    }
}
