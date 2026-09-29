using System;

namespace A02_01;

class Programm
{
    static void Main(string[] args)
    {
        byte num1,num2;
        Console.WriteLine("Escribe un número entero de dos cifras: ");
        //99/10 = 9.9
        while(!byte.TryParse(Console.ReadLine(),out num1) || num1<10 || num1>99)
        {                    
            Console.WriteLine("No es un dato válido. Por favor, introduzca un número entero de dos cifras: ");
        }
        Console.WriteLine("Escribe otro número entero de dos cifras: ");
        while(!byte.TryParse(Console.ReadLine(),out num2) || num1<10 || num2>99)
        {                    
            Console.WriteLine("No es un dato válido. Por favor, introduzca un número entero de dos cifras: ");
        }
 
        ushort num1_u = (ushort) num1;
        ushort num2_u = (ushort) num2;

       /*Cuando se hacen operaciones aritméticas con números más pequeños que int 
        el compilador promueve automáticamente los valores int antes de hacer 
        la operación
        */    
        ushort resultado = (ushort) (num1*num2);

        Console.WriteLine(resultado);
    }
}