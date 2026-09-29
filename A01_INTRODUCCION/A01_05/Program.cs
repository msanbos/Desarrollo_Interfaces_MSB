using System;

namespace A01_05;

class Program
{
    static void Main (string[] args)
    {
        int _1entero = 321;
        int _2entero = 698;

        //Hacemos un cast a uno de las variables, eso casteara todas y mostrará un valor double
        Console.WriteLine("321 / 698 = "+(double)_1entero/_2entero);
    }
}