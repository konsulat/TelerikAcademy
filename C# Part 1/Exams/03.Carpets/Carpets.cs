using System;

class Carpets
{
    static void Main()
    {
        string inputLines = Console.ReadLine();
        int lines = int.Parse(inputLines);
        int elementsOnLine = lines;
        int center = elementsOnLine / 2;

        for (int i = 1; i <= lines / 2; i++)
        {
            int elPos = 1;
            while (elPos <= elementsOnLine)
            {
                if ((elPos <= center - i) || (elPos > center + i))
                {
                    Console.Write(".");
                    elPos++;
                }
                else
                {
                    if (elPos <= center)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("/");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                    }
                    else
                    {
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("\\");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        for (int i = lines / 2; i > 0; i--)
        {
            int elPos = 1;
            while (elPos <= elementsOnLine)
            {
                if ((elPos <= center - i) || (elPos > center + i))
                {
                    Console.Write(".");
                    elPos++;
                }
                else
                {
                    if (elPos <= center)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("\\");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                    }
                    else
                    {
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("/");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
