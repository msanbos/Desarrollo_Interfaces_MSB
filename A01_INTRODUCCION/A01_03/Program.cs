using System;

namespace A01_03;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("-8 + 6 x 3 = "+(-8+6*3));
        Console.WriteLine("(2 + 7) % 5 = "+((2+7)%5));
        Console.WriteLine("2 + (-1 x 8) -5 % 3 = "+(2+(-1*8)-5%3));
    }
}