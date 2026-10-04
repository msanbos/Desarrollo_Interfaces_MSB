using System;

namespace A03_09;

class Programm
{
    static void  Main(string[] args)
    {
        int alto,ancho;
        //PEDIMOS LOS DATOS
        Console.WriteLine("CUADRADO DE ASTERISCOS");
        Console.Write("Escribe un alto: ");
        while(!int.TryParse(Console.ReadLine(), out alto))
        {
            Console.Write("No es un número válido. Escribe un número entero: ");
        }
        Console.Write("Escribe un ancho: ");
        while(!int.TryParse(Console.ReadLine(), out ancho))
        {
            Console.Write("No es un número válido. Escribe un número entero: ");
        }
        //LUEGO TENEMOS QUE ENCADENAR FOR, El EXTERNO DEFINIRÁ LAS FILAS y EL INTERNO COLUMNAS
        for(int i = 0; i < alto; i++)
        {
            for(int j=0; j< ancho; j++)
            {
                Console.Write("*");
            }
            //Salto de linea cuando acabe la fila
            Console.WriteLine();
        }
    }
}
