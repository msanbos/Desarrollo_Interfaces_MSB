using System;

namespace A02_06;

class Program
{
    static void Main(string[] args)
    {
        //Pedimos el número
        int numero;
        Console.WriteLine("Escribe con un número entero cuantas letras va a tener tu palabra: ");
        while(!int.TryParse(Console.ReadLine(), out numero)||numero <= 0)
        {
            Console.WriteLine("El número no es válido. Por favor indica el tamaño de tu palabra con un número entero: ");
            Console.WriteLine("Por favor, indica el tamaño de tu palabra con un número entero: ");
        }
        //Aquí no se puede poner un array "palabra[]" como en Java
        char []palabra = new char [numero];
        for ( int i = 0; i < numero; i++)
        {   
            Console.WriteLine("Escribe una letra: ");
            //Realmente como la lectura es un string, llamando al índice directamente
            //podríamos recogerlo: char letra = Console.ReadLine()[0];

            //Nos salta un aviso de que string no soporta valores nulos y que puede pasar
            string entrada = Console.ReadLine();            
            /*FORMAS DE SOLUCIONARLO:
            **INDICAR QUE EL STRING PUEDE SER NULO CON (?)
            string? entrada = Console.ReadLine();
            **USAR OPERADOR DE FUSIÓN NULA
            Se le puede indicar que si devuelve null lo rellene con "" (vacío)
            string entrada = Console.ReadLine() ?? string.Empty;
            */
            char letra ;
            
            if (!string.IsNullOrEmpty(entrada))
            {
                letra = entrada[0];
                
            }
            else
            {
                letra = ' ';
            }

            palabra[i] = letra;
            
        }
        Console.WriteLine(palabra);
        //La mostramos invertida con un for inverso
        for(int i = palabra.Length - 1; i >= 0; i--)
        {
            /*Así siempre salta de linea como un /n (carro de línea)
            Console.WriteLine(palabra[i]);
            Para evitar esto; ACABAMOS DE DESCUBRIR Console.Write()!!!
            A partir de ahora no dejaremos de usarlo :DDD
            */       
            Console.Write(palabra[i]);        
        }
    }
}