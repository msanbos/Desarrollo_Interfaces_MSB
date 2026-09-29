using System;

namespace A01_06;

class Program
{
    static void Main(string[] args)
    {
        int num1,num2;
        Console.WriteLine("Escribe un número entero: ");
        while(!int.TryParse(Console.ReadLine(),out num1))
        {
            Console.WriteLine("No es un número válido. Escribe un número entero: ");
        }

        Console.WriteLine("Escribe otro número entero: ");
        while(!int.TryParse(Console.ReadLine(),out num2))
        {
            Console.WriteLine("No es un número válido. Escribe otro número entero: ");
        }

        Console.WriteLine("El resultado de la división de los números "+num1+" y "+num2+" es "+(num1/num2));
        Console.WriteLine("El resto de esta división es "+(num1%num2));
    }
}