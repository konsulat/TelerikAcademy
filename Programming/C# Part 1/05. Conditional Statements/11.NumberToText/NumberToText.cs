// 11.* Write a program that converts a number in the range [0...999] to a text corresponding to
// its English pronunciation. Examples:
//	0 → "Zero"
//	273 → "Two hundred seventy three"
//	400 → "Four hundred"
//	501 → "Five hundred and one"
//	711 → "Seven hundred and eleven"

using System;

class NumberToText
{
    static void Main()
    {
        int number;
        bool isInt = false;

        Console.Write("Enter an integer in range [0.. 999]: ");

        isInt = int.TryParse(Console.ReadLine(), out number);

        if (!isInt || number < 0 || number > 999)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int hundreds = number / 100;
        int tens = (number / 10) % 10;
        int ones = number % 10;
        string output = string.Empty;

        if (hundreds != 0)
        {
            switch (hundreds)
            {
                case 1: output = "One"; break;
                case 2: output = "Two"; break;
                case 3: output = "Three"; break;
                case 4: output = "Four"; break;
                case 5: output = "Five"; break;
                case 6: output = "Six"; break;
                case 7: output = "Seven"; break;
                case 8: output = "Eight"; break;
                case 9: output = "Nine"; break;
            }

            output += " hundred";

            if ((tens == 0 && ones != 0) || tens == 1 || (tens != 0 && tens != 1 && ones == 0))
            {
                output += " and";
            }
        }

        if (tens != 0)
        {
            switch (tens)
            {
                case 1:
                    if (ones == 0)
                    {
                        output += (output != string.Empty ? " ten" : "Ten");
                    }
                    else if (ones == 1)
                    {
                        output += (output != string.Empty ? " eleven" : "Eleven");
                    }
                    else if (ones == 2)
                    {
                        output += (output != string.Empty ? " twelve" : "Twelve");
                    }
                    else if (ones == 3)
                    {
                        output += (output != string.Empty ? " thirteen" : "Thirteen");
                    }
                    else if (ones == 4)
                    {
                        output += (output != string.Empty ? " fourteen" : "Fourteen");
                    }
                    else if (ones == 5)
                    {
                        output += (output != string.Empty ? " fifteen" : "Fifteen");
                    }
                    else if (ones == 6)
                    {
                        output += (output != string.Empty ? " sixteen" : "Sixteen");
                    }
                    else if (ones == 7)
                    {
                        output += (output != string.Empty ? " seventeen" : "Seventeen");
                    }
                    else if (ones == 8)
                    {
                        output += (output != string.Empty ? " eighteen" : "Eighteen");
                    }
                    else if (ones == 9)
                    {
                        output += (output != string.Empty ? " nineteen" : "Nineteen");
                    }
                    break;
                case 2:
                    output += (output != string.Empty ? " twenty" : "Twenty");
                    break;
                case 3:
                    output += (output != string.Empty ? " thirty" : "Thirty");
                    break;
                case 4:
                    output += (output != string.Empty ? " forty" : "Forty");
                    break;
                case 5:
                    output += (output != string.Empty ? " fifty" : "Fifty");
                    break;
                case 6:
                    output += (output != string.Empty ? " sixty" : "Sixty");
                    break;
                case 7:
                    output += (output != string.Empty ? " seventy" : "Seventy");
                    break;
                case 8:
                    output += (output != string.Empty ? " eighty" : "Eighty");
                    break;
                case 9:
                    output += (output != string.Empty ? " ninety" : "Ninety");
                    break;
            }
        }

        if (ones != 0 && tens != 1)
        {
            switch (ones)
            {
                case 1:
                    output += (output != string.Empty ? " one" : "One");
                    break;
                case 2:
                    output += (output != string.Empty ? " two" : "Two");
                    break;
                case 3:
                    output += (output != string.Empty ? " three" : "Three");
                    break;
                case 4:
                    output += (output != string.Empty ? " four" : "Four");
                    break;
                case 5:
                    output += (output != string.Empty ? " five" : "Five");
                    break;
                case 6:
                    output += (output != string.Empty ? " six" : "Six");
                    break;
                case 7:
                    output += (output != string.Empty ? " seven" : "Seven");
                    break;
                case 8:
                    output += (output != string.Empty ? " eight" : "Eight");
                    break;
                case 9:
                    output += (output != string.Empty ? " nine" : "Nine");
                    break;
            }
        }

        if (output == string.Empty)
        {
            output = "Zero";
        }

        Console.WriteLine("English pronunciation: {0}", output);
    }
}
