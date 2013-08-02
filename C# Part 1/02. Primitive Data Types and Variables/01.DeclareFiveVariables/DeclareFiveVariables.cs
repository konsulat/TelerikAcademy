using System;

class DeclareFiveVariables
{
    static void Main()
    {
        ushort ushortNumber = 52130;
        sbyte sbyteNumber = -115;
        int intNumber = 4825932;
        byte byteNumber = 97;
        short shortNumber = -10000;
        Console.WriteLine("First variable (unsigned short): {0}", ushortNumber);
        Console.WriteLine("Second variable (signed byte): {0}", sbyteNumber);
        Console.WriteLine("Third variable (integer): {0}", intNumber);
        Console.WriteLine("Fourth variable (byte): {0}", byteNumber);
        Console.WriteLine("Fifth variable (short): {0}", shortNumber);
    }
}
