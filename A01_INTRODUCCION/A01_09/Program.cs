using System;

namespace A01_09;

class Program
{
    static void Main(string[] args)
    {   
        double numero;
        Console.WriteLine("Escribe un número: ");
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("No es un carácter válido. Por favor, introduce un número: ");
        }
        //Sin concatenar cadenas podemos usar mostrarlo por posición
        Console.WriteLine("{0} x 1 = {1}",numero,numero*1);
        Console.WriteLine("{0} x 2 = {1}",numero,numero*2);
        Console.WriteLine("{0} x 3 = {1}",numero,numero*3);
        Console.WriteLine("{0} x 4 = {1}",numero,numero*4);
        Console.WriteLine("{0} x 5 = {1}",numero,numero*5);
        Console.WriteLine("{0} x 6 = {1}",numero,numero*6);
        Console.WriteLine("{0} x 7 = {1}",numero,numero*7);
        Console.WriteLine("{0} x 8 = {1}",numero,numero*8);
        Console.WriteLine("{0} x 9 = {1}",numero,numero*9);
        Console.WriteLine("{0} x 10 = {1}",numero,numero*10);
    }
}