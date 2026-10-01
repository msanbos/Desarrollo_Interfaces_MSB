using System;
using System.Linq.Expressions;

namespace A03_06;

class Program
{
    static void Main (string[] args)
    {
        int numero,numSecreto;
        //Para número random
        Random random = new Random();
        numSecreto = random.Next(1,101); //Entre el 1 y 100
        Console.WriteLine("¡¡ADIVINA EL NÚMERO DEL 1 AL 100!!");
        
       
        do
        {
            Console.Write("Escribe un número: ");
             while(!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("No es un número válido. Escribe un número: ");
            }

            if (numero>numSecreto)
            {
                Console.WriteLine("El número secreto es menor!");
            }
            else
            {
                Console.WriteLine("El número secreto es mayor!");
            }

        }while(numero != numSecreto);

        Console.WriteLine("¡ENHORABUENA! ACERTASTE!!");
    }
}