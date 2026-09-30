using System;

namespace A02_10;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        do
        {
            Console.WriteLine("Escribe un número entero: ");
            Console.WriteLine("[Introduce 0 para SALIR]");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("No es un valor válido. Introduce un número entero: ");
            }
            //Si es 0 se despide y no muestra el resultado 
            if(numero == 0)
            {
                Console.WriteLine("Adiós!");
                break;
            }            
            //Calculamos los números con herramientas C# usamos el método Convert.ToString(numero,base)
            string hexa = Convert.ToString(numero,16);
            string octal = Convert.ToString(numero,8);
            string bin = Convert.ToString(numero,2);
            Console.WriteLine($"Número : {numero} OCTAL: {octal} HEX: {hexa} BIN: {bin}");

        }while(numero != 0);
    }
}