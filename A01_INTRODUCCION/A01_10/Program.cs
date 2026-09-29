using System;

class Program
{
    static void Main (string[] args)
    {
        //int nos salta como un número no válido y nos lanza negativo porque solo alberga 32 bits, usamos long que es un tipo de dato de número entero de 64 bits
        long numA,numB,resultado;
        //129070 x 20689 = 2.670.329.230
        Console.WriteLine("-----------------------------");
        Console.WriteLine("CALCULADORA DE MULTIPLICAR");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Introduce un número: ");
        while(!long.TryParse(Console.ReadLine(),out numA))
        {
            Console.WriteLine("No es válido. Escribe un número entero: ");
        }
        Console.WriteLine("Introduce otro número: ");
        while(!long.TryParse(Console.ReadLine(),out numB))
        {
            Console.WriteLine("No es válido. Escribe un número entero: ");
        }
        resultado = numA * numB;
        Console.WriteLine(numA+" x "+numB+" = "+resultado);
    }
}