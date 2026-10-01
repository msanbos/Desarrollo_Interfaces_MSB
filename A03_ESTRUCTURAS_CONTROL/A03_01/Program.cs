using System;

namespace A03_01;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        Console.Write("¡Comprueba si tu número entero es par! Escribe un número: ");
        while(!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("\nEl número no es válido.Escribe un número entero: ");
        }
        if(numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es par");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar");
        }

        
    }
}