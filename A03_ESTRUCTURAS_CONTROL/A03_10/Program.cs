using System;
using System.ComponentModel;

namespace A03_10;

class Program
{
    static void Main(string[] args)
    {
        int dinero;
        Console.WriteLine("CONTADOR DE BILLETES");
        Console.Write("Introduce una cantidad(número entero) de dinero: ");
        while(!int.TryParse(Console.ReadLine(), out dinero))
        {
            Console.Write("No es un número válido. Introduce un número entero: ");
        }
        Console.WriteLine("Monedas y billetes");
        Console.WriteLine("200€ = "+(int)dinero/200);//Al castearlo tenemos la parte entera
        //Sacamos el resto de la operacion y la guardamos en la variable
        dinero = dinero % 200;
        Console.WriteLine("100€ = "+(int)dinero/100);
        dinero = dinero % 100;
        Console.WriteLine("50€ = "+(int)dinero/50);
        dinero = dinero % 50;
        Console.WriteLine("20€ = "+(int)dinero/20);
        dinero = dinero % 20;
        Console.WriteLine("10€ = "+(int)dinero/10);
        dinero = dinero % 10;
        Console.WriteLine("5€ = "+(int)dinero/5);
        dinero = dinero % 5;
        Console.WriteLine("2€ = "+(int)dinero/2);
        dinero = dinero % 2;
        Console.WriteLine("1€ = "+(int)dinero/1);
    }
}