using System;

namespace A01_02;

class Programm
{

    static void Main(String[] args)
    {
        Console.WriteLine("SUMA: "+6+" + "+2+" = "+(6+2));
        Console.WriteLine("RESTA: "+6+" - "+2+" = "+(6-2));
        Console.WriteLine("MULTIPLICACIÓN: "+6+" x "+2+" = "+(6*2));
        Console.WriteLine("DIVISIÓN: "+6+" / "+2+" = "+(6/2));
        Console.WriteLine("MÓDULO: "+6+" % "+2+" = "+(6%2));



        /*CON VARIABLES Y USANDO DISTINTAS FORMAS DE MOSTRAR INFORMACIÓN

        int num1,num2;
        num1 = 6;
        num2 = 2;

        //CONCATENANDO
        Console.WriteLine("SUMA: "+num1+" + "+num2+" = "+(num1+num2));
        Console.WriteLine("RESTA: "+num1+" - "+num2+" = "+(num1-num2));

        //CON $ y {] como en script o terminal
        Console.WriteLine($"MULTIPLICACIÓN: {num1} x {num2} = "+(num1*num2));
        Console.WriteLine($"DIVISIÓN: {num1} / {num2} = "+(num1/num2));
        
        //Con la posición de los atriutos al final
        Console.WriteLine("RESTO/MÓDULO: {0} % {1} = "+(num1%num2),num1,num2);
        */
    }
}