using System;

namespace A02_09;

class Program
{
    static void Main(string[] args)
    {
        int x,y;
        for(x = -8;x <= 8; x++)
        {
            //valor de y
            y = x * x;
            //8*8 = 64 encaja en las 80 caracteres que nos pide el ejemplo
            for(int i = 0; i < y; i++)
            {
                Console.Write(" ");
            }
            //Una vez dibujados los espacios, dibujamos el * y saltamos de línea
            Console.WriteLine("*");            
        }
    }
}
