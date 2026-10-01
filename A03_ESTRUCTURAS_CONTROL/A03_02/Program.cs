using System;
using System.Timers;

namespace A03_02;

class Program
{
    static void Main (string[] args)
    {
        int num1,num2;
        Console.Write("Escribe un número: ");
        while(!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("\nEl número no es válido. Introduce un número entero: ");
        }
        Console.Write("Escribe otro número: ");
        while(!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("\nEl número no es válido. Introduce un número entero: ");
        }

        if (num1 > num2) 
        {
            if(num1%num2 == 0)
            {
                Console.WriteLine($"El número {num1} es múltiplo de {num2}");
            }
            else
            {
                Console.WriteLine($"El número {num1} NO es múltiplo de {num2}");
            }

        }
        else
        {
            if(num2%num1 == 0)
            {
                Console.WriteLine($"El número {num2} es múltiplo de {num1}");
            }
            else
            {
                Console.WriteLine($"El número {num2} NO es múltiplo de {num1}");
            }            
        }
    }
}
