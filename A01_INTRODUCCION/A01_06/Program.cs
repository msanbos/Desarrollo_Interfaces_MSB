using System;

namespace A01_06;

class Program
{
    static void Main (string[] args)
    {        
        Console.WriteLine("----------------------------------");
        Console.WriteLine("   CONVERSOR DE METROS A MILLAS");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Introduce una distancia en metros: ");   
        string input = Console.ReadLine();
        /* TRYPARSE(in,out)
        -Hace la conversion de String (lectura) a el tipo que sea. 
        -Este método devuelve True/False, pero si no se cumple devuelve a la salida 0 o el valor nulo por defecto
        -No lanza excepción
        -Métodos string.IsNullOrEmpty o string.IsNullOrWhiteSpace para comprobar las cadenas
        */        
        Console.WriteLine("----------------------------------");
        
        if(double.TryParse(input,out double dist))
        {                        
            double resultado = dist/1609.0;   
            //Mostramos con la forma de la posición para poder usar especificdores.(F: Fixed Point)
            Console.WriteLine("{0} metros son {1:F4} millas.",dist,resultado);
        }
        else
        {
            Console.WriteLine("Expresión no válida");
        }    
        Console.WriteLine("----------------------------------");
        /* BUCLE DE ERROR WHILE
        while(!double.TryParse(Console.ReadLine(),out dist))
        {
            Console.WriteLine("Expresión no válida. Introduce un número de metros.")
        }
        */
    }
}