using System;

namespace A03_08;

class Program
{
    static void Main(string[] args)
    {
        //Creamos un array de 5 posiciones
        string []nombres = new string[5];

        Console.WriteLine("Introduce 5 nombres.");
        for(int i = 0; i < 5; i++)
        {
            Console.Write(i+1+"-Escribe un nombre: ");
            nombres[i]=Console.ReadLine();
        }
        Console.WriteLine("Los nombres sin \"a\" son: ");
        foreach(string nombre in nombres)
        {
            if (!nombre.ToLower().Contains('a'))
            {
                Console.Write(nombre+" ");
            }
        }
    }
}
