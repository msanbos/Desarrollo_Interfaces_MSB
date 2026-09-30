using System;

namespace A02_05;

class Program
{
    static void Main(string[] args)
    {
        bool bool1 = true;
        bool bool2 = true;
        bool bool3 = false;
        bool bool4 = bool1 && bool2;
        bool bool5 = bool1 || bool3;

        Console.WriteLine(bool1+" AND "+bool2+ " = "+bool4);
        Console.WriteLine(bool1+" OR "+bool3+ " = "+bool5);


    }
}