using System;

namespace A03_05;

class Program
{
    static void Main (string[] args)
    {
        int numero;
        Console.Write("Introduce un número: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("No es un número válido. Introduce un número entero: ");
        }
        numero = numero>0? numero:-numero;
        Console.WriteLine("El número escrito es: "+numero);
    }
}
