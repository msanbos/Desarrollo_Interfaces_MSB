using System;

namespace A02_02;
class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        //primero incrementa a y luego la asigna
        int b = ++a;
        //Primero asigna a c el valor de a y luego la incrementa
        int c = a++;
        //a tiene dos incrementos a+2
        int d = a*2;

        Console.WriteLine("a = "+a+", b = "+b+",c = "+c+",d = "+d);

    }
}