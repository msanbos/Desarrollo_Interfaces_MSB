using System;

namespace A02_04;

class Program
{
    static void Main(string[] args)
    {
        double radio,area;
        Console.WriteLine("---CALCULADORA DE ÁREA DEL CÍRCULO---");
        Console.WriteLine("Introduce un radio: ");
        while(!double.TryParse(Console.ReadLine(),out radio))
        {
            Console.WriteLine("No es un comando válido");
        }
        area = Math.PI * Math.Pow(radio,2);

        Console.WriteLine("Su área es: {0:F2}",area);
    }
}
