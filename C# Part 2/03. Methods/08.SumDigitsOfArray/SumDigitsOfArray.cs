using System;

class SumDigitsOfArray
{
    static void SumDigits(byte[] firstArr, byte[] secondArr)
    {
        byte[] sumArr = new byte[Math.Max(firstArr.Length, secondArr.Length) + 1];
        Array.Reverse(firstArr);
        Array.Reverse(secondArr);
        int addToNext = 0;
        int tempNum = 0;

        string maxArray = "";
        int max = 0;
        int min = 0;

        if (firstArr.Length >= secondArr.Length)
        {
            maxArray = "first";
            max = firstArr.Length;
            min = secondArr.Length;
        }
        else
        {
            maxArray = "second";
            max = secondArr.Length;
            min = firstArr.Length;
        }

        for (int i = 0; i < min; i++)
        {
            tempNum = firstArr[i] + secondArr[i] + addToNext;
            if (tempNum >= 10)
            {
                addToNext = 1;
                tempNum %= 10; 
            }
            else
            {
                addToNext = 0;
            }

            sumArr[i] = (byte)tempNum;
        }

        for (int i = min + 1; i < max; i++)
        {
            if (maxArray == "first")
            {
                tempNum = firstArr[i] + addToNext;
            }
            else if (maxArray == "second")
            {
                tempNum = secondArr[i] + addToNext;
            }

            if (tempNum >= 10)
            {
                addToNext = 1;
                tempNum %= 10;
            }
            else
            {
                addToNext = 0;
            }

            sumArr[i] = (byte)tempNum;
        }

        sumArr[sumArr.Length - 1] = (byte)addToNext;

        Array.Reverse(sumArr);

        Console.WriteLine("Sum: ");
        if (sumArr[0] != 0)
        {
            Console.Write(sumArr[0]);
        }
        for (int i = 1; i < sumArr.Length; i++)
        {
            Console.Write(sumArr[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        byte[] firstArr = { 1, 7, 4, 2, 7, 8, 9, 8, 1, 2, 4, 4, 1, 1, 2 };
        byte[] secondArr = { 3, 7, 8, 3, 1, 7, 5, 5 };

        SumDigits(firstArr, secondArr);
    }
}
