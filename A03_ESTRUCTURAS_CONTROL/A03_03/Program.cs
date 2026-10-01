using System;

namespace A03_03;

class Programm
{
    static void Main(string[] args)
    {
        int numero = 0;
        Console.Write("Introduce un número del 1 al 9: ");
        while(!int.TryParse(Console.ReadLine(), out numero) && numero>9 && numero<0)
        {
            Console.Write("No es un número válido. Introduce un número del 1 al 9: ");
        }
        /* CON SWITCH YIELD SERÍA
        string resultado = numero switch
        {
            0 => "Cero"
            (...)
            _=> "Error"
        }
        
        */
        switch(numero){
            case 0 :   
                Console.WriteLine("CERO");
                break;
            case 1 :
                Console.WriteLine("UNO");
                break;
            case 2 :
                Console.WriteLine("DOS");
                break;
            case 3 :
                Console.WriteLine("TRES");
                break;
            case 4 :
                Console.WriteLine("CUATRO");
                break;
            case 5 :
                Console.WriteLine("CINCO");
                break;
            case 6 :
                Console.WriteLine("SEIS");
                break;
            case 7 :
                Console.WriteLine("SIETE");
                break;   
            case 8 :
                Console.WriteLine("OCHO");
                break;
            case 9 :
                Console.WriteLine("NUEVE");
                break;
            default :
                Console.WriteLine("No es nu número válido");
                break;    
        }
    }
}
