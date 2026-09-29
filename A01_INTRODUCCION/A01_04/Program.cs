using System;

namespace A01_04;

class Programm
{
    static void Main (String[] args)
    {
        int num1,num2,num3,num4,num5,num6,num7;
        num1 = 1;
        num2 = 2;
        num3 = 3;
        num4 = 5;
        num5 = 7;
        num6 = 6;
        num7 = 8;

        Console.WriteLine("-8 + 6 x 3 = "+(-num7+num6*num3));
        Console.WriteLine("(2 + 7) % 5 = "+((num2+num5)%num4));
        Console.WriteLine("2 + (-1 x 8) -5 % 3 = "+(num2+(-num1*num7)-num4%num3));
    }
}