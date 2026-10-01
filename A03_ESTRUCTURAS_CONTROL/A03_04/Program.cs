using System;

namespace A03_04;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        do
        {
            Console.Write("Introduce un número entero múltiplo de 2,3 y 7: ");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("\nNo es un número válido. Introduce un número entero múltiplo de 2,3 y 7: ");
            }
            if(numero % 2 != 0 || numero % 3 != 0 || numero % 7 != 0)
            {
                Console.WriteLine($"El número {numero} NO es múltiplo de 2, 3 y 7");
            }

        }while(numero % 2 != 0 || numero % 3 != 0 || numero % 7 != 0); // OR ; mientras falle alguno de ellos

        Console.WriteLine($"El número {numero} es multiplo de 2,3 y 7!!");
        
    }
}