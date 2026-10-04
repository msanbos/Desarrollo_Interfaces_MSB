using System;

namespace A03_07;

class Program
{
    static void Main (string[] args)
    {
        Console.Write("Escribe un carácter: ");
        string entrada = Console.ReadLine();
        //Cogemos el carácter que necesitamos
        char caracter = entrada[0];
        //Es un caracter, por tanto usamos comillas simples('')
        switch (caracter)
        {   //No funciona &, || , hay que escribir las palabras
            case >='0'and <='9':
            Console.WriteLine("Es un número.");
            break;
            case '.' or ',' or ';' or ':':
            Console.WriteLine("Es un signo de puntuación");
            break;
            default:
            Console.WriteLine("Es otro carácter");
            break;
        }
    }
}