using System;

namespace A02_08;

class Program
{
    static void Main (string[] args)
    {
        int verde, rojo, azul;
        Console.Write("----CONVERSOR DE NÚMEROS ENTEROS A HEXADECIMAL----");

        Console.WriteLine("Introduce valores de 0 a 255: ");
        Console.Write(" -Verde: ");
        while(!int.TryParse(Console.ReadLine(),out verde) || verde<0 || verde>255)
        {
            Console.Write("\nNo es un valor válido. Introduce un número entero de 0 a 255: ");
        }
        Console.Write(" -Rojo: ");
        while(!int.TryParse(Console.ReadLine(),out rojo) || rojo<0 || rojo>255)
        {
            Console.Write("\nNo es un valor válido. Introduce un número entero de 0 a 255: ");
        }
        Console.Write(" -Azul: ");
        while(!int.TryParse(Console.ReadLine(),out azul) || azul<0 || azul>255)
        {
            Console.Write("\nNo es un valor válido. Introduce un número entero de 0 a 255: ");
        }

        Console.WriteLine("El color ({0},{1},{2}) es : #{0:X2}{1:X2}{2:X2}",verde,rojo,azul);
    }
}