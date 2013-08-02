using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
		{
            int number = int.Parse(Console.ReadLine());

            string normalNumberAsString = Convert.ToString(number, 2);
            string reversedNumberAsString = "";

            for (int j = normalNumberAsString.Length - 1; j >= 0; j--)
            {
                reversedNumberAsString += normalNumberAsString[j];
            }
            int endResult = Convert.ToInt32(reversedNumberAsString, 2);
            Console.WriteLine(endResult);
		}
    }
}
