using System;

namespace A02_03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("13 : 6");
        Console.WriteLine("int -> "+(13/6));//Por defecto un entero es int
        Console.WriteLine("float -> "+(float)(13.0/6.0));
        Console.WriteLine("double -> "+(13.0/6.0));//Por defecto un decimal es double
        Console.WriteLine("decimal -> "+(decimal)(13.0/6.0));
    }
}