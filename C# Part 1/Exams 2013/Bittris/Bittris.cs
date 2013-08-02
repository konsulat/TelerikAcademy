using System;

class Bittris
{
    static void Main()
    {
        uint row0 = 0;
        uint row1 = 0;
        uint row2 = 0;
        uint row3 = 0;

        string numberAsString = null;
        while (true)
        {
            numberAsString = Console.ReadLine();
            if (numberAsString == null)
            {
                return;
            }

            string commands =
                Console.ReadLine() +
                Console.ReadLine() +
                Console.ReadLine();
            uint number = uint.Parse(numberAsString);

            int numberOfBits = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((number & (1 << i)) != 0)
                {
                    numberOfBits += 1;
                }
            }

            for (int thisRowNumber = 0; thisRowNumber < 3; thisRowNumber++)
            {
                char command = commands[thisRowNumber];
                if (command == 'L')
                {
                    if ((number & (1 << 7)) != 0)
                    {
                        number <<= 1;
                    }
                }
                else if (command == 'R')
                {
                    if ((number & 1) == 0)
                    {
                        number >>= 1;
                    }
                }

                uint newtRow = 0;

                switch (thisRowNumber)
                {
                    case 0: newtRow = row1; break;
                    case 1: newtRow = row2; break;
                    case 2: newtRow = row3; break;
                }

                if ((newtRow & number) == 0)
                {
                    uint nextRowValue = newtRow | number;
                }
            }

        }
    }
}
