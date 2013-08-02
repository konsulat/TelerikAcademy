using System;

class NumberToText
{
    static void Main()
    {
        int number;
        bool isInt;
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
        string output = "";
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
                        output += (output != "" ? " ten" : "Ten");
                    }
                    else if (ones == 1)
                    {
                        output += (output != "" ? " eleven" : "Eleven");
                    }
                    else if (ones == 2)
                    {
                        output += (output != "" ? " twelve" : "Twelve");
                    }
                    else if (ones == 3)
                    {
                        output += (output != "" ? " thirteen" : "Thirteen");
                    }
                    else if (ones == 4)
                    {
                        output += (output != "" ? " fourteen" : "Fourteen");
                    }
                    else if (ones == 5)
                    {
                        output += (output != "" ? " fifteen" : "Fifteen");
                    }
                    else if (ones == 6)
                    {
                        output += (output != "" ? " sixteen" : "Sixteen");
                    }
                    else if (ones == 7)
                    {
                        output += (output != "" ? " seventeen" : "Seventeen");
                    }
                    else if (ones == 8)
                    {
                        output += (output != "" ? " eighteen" : "Eighteen");
                    }
                    else if (ones == 9)
                    {
                        output += (output != "" ? " nineteen" : "Nineteen");
                    }
                    break;
                case 2:
                    output += (output != "" ? " twenty" : "Twenty");
                    break;
                case 3:
                    output += (output != "" ? " thirty" : "Thirty");
                    break;
                case 4:
                    output += (output != "" ? " forty" : "Forty");
                    break;
                case 5:
                    output += (output != "" ? " fifty" : "Fifty");
                    break;
                case 6:
                    output += (output != "" ? " sixty" : "Sixty");
                    break;
                case 7:
                    output += (output != "" ? " seventy" : "Seventy");
                    break;
                case 8:
                    output += (output != "" ? " eighty" : "Eighty");
                    break;
                case 9:
                    output += (output != "" ? " ninety" : "Ninety");
                    break;
            }
        }
        if (ones != 0 && tens != 1)
        {
            switch (ones)
            {
                case 1:
                    output += (output != "" ? " one" : "One");
                    break;
                case 2:
                    output += (output != "" ? " two" : "Two");
                    break;
                case 3:
                    output += (output != "" ? " three" : "Three");
                    break;
                case 4:
                    output += (output != "" ? " four" : "Four");
                    break;
                case 5:
                    output += (output != "" ? " five" : "Five");
                    break;
                case 6:
                    output += (output != "" ? " six" : "Six");
                    break;
                case 7:
                    output += (output != "" ? " seven" : "Seven");
                    break;
                case 8:
                    output += (output != "" ? " eight" : "Eight");
                    break;
                case 9:
                    output += (output != "" ? " nine" : "Nine");
                    break;
            }
        }
        if (output == "")
        {
            output += "Zero";
        }
        Console.WriteLine("English pronunciation: {0}", output);
    }
}
