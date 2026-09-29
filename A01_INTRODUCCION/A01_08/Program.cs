using System;

namespace A01_08;

class Program
{
    static void Main(string[] args)
    {
        double numero;
        Console.WriteLine("Introduce un número: ");
        while(!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("No es un carácter válido, introduce un número: ");
        }
        Console.WriteLine("El número escrito es "+numero+", su doble es "+numero*2+" y su triple "+numero*3);
    }
}