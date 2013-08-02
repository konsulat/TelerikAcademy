using System;

class ShipDamage
{
    static void Main()
    {
        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());
        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());

        int h = int.Parse(Console.ReadLine());

        int cX1 = int.Parse(Console.ReadLine());
        int cY1 = int.Parse(Console.ReadLine());
        int cX2 = int.Parse(Console.ReadLine());
        int cY2 = int.Parse(Console.ReadLine());
        int cX3 = int.Parse(Console.ReadLine());
        int cY3 = int.Parse(Console.ReadLine());

        cY1 = 2 * h - cY1;
        cY2 = 2 * h - cY2;
        cY3 = 2 * h - cY3;

        if (sX1 > sX2)
        {
            int temp = sX1;
            sX1 = sX2;
            sX2 = temp;
        }

        if (sY1 > sY2)
        {
            int temp = sY1;
            sY1 = sY2;
            sY2 = temp;
        }

        int damage = 0;
        if (sX1 < cX1 && cX1 < sX2 && sY1 < cY1 && cY1 < sY2)
        {
            damage += 100;
        }
        else if (cX1 == sX2 && sY2 < cY1 && cY1 < sY1)
        {
            damage += 50;
        }
        else if (cX2 == sX1 && sY2 < cY1 && cY1 > sY1)
        {
            damage += 50;
        }
    }
}
