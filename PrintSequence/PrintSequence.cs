//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...



using System;

class PrintSequence
{
    static void Main()
    {
        int i = 2;
        while (Math.Abs(i) < 12)
        {
            Console.WriteLine(i);
            if (i > 0)
            {
                i++;
                i = i * (-1);
            }
else
            {
                i--;
                i = i * (-1);
            }
        }
    }
}
