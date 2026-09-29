using System;

namespace A02_07;

class Program
{
    static void Main(string[] args)
    {
        for (int i=1;i<=100;i++)
        {
            //Para mostrar las cifras que queramos usaremos el especificador decimal(D)
            Console.Write("{0:D3} ",i);
        }
    }
}
