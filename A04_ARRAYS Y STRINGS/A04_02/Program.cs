using System;
using System.Security.Principal;

namespace A04_02;

class Program
{
    /*
    Crea un programa que almacene en un vector
    los días de cada mes del año (no bisiesto) y luego pida al
    usuario un mes y el número de día del mes. El programa
    devolverá el día del año. [Ej: 3 de febrero → Día 34 del año]
    */
    static void Main (string[] args)
    {
        string mes;
        int dia;
        int []diasAnyo = new int [365];
        
        //Rellenamos el array
        for(int i=0; i<365; i++)
        {
            diasAnyo[i] = i+1;
        }
        //PEDIMOS EL MES
        Console.Write("Escribe un mes: ");
        mes = Console.ReadLine();
        //Lo pasamos a minúscula para evitar errores
        mes = mes.ToLower();
        //PEDIMOS EL DÍA
        Console.Write("Escribe un día: ");
        while(!int.TryParse(Console.ReadLine(), out dia))
        {
            Console.Write("No es un número válido. Introduce número: ");
        }
        //Mostramos la fecha introducida
        Console.Write(dia+" de "+mes+" -> ");
        switch (mes)
        {
            case "enero" : //31 días (empieza en 1, le sumamos 30) ; diasAnyo[0] -> diasAnyo[30]
            Console.WriteLine("Día "+(diasAnyo[0]+dia)+" del año.");
            break;
            case "febrero" : //28 días ; diasAnyo[30] -> diasAnyo[57]
            Console.WriteLine("Día "+(diasAnyo[30]+dia)+" del año.");
            break;
            case "marzo" : //31 días ; diasAnyo[57] -> diasAnyo[90]
            Console.WriteLine("Día "+(diasAnyo[57]+dia)+" del año.");
            break;
            default :
            Console.WriteLine("No es un mes válido.");
            break;


        }

    }
}
