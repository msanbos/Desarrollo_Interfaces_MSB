using System;

namespace A04_01;

class Program
{
    /*
    Solicita al usuario diez números double y
    almacénalos en un vector, posteriormente muestra por pantalla
    la media, la moda (número que más se repite) de la parte
    entera y todos los números que sean inferiores a la media.
    */
    static void Main(string[] args)
    {
        double media, moda, suma = 0;
        //Creamos un array de diez posiciones
        double []numeros = new double [10];
        //declaramos fuera el indice para la media
        int indice;
        for(indice=0;indice < 10; indice++)
        {
            double numero ;

            Console.Write(indice+1+".-introduce un número: ");
            while(!double.TryParse(Console.ReadLine(),out numero))
            {
                Console.Write("No es un número válido. Introduce un número real: ");
            }    
            suma += numero;
            numeros[indice]= numero;
        }

        media = suma / indice;
        //Cogemos el primer numero de ejemplo para comparar
        moda = numeros[0];
        int repeticionesMax = 0;//Contador para guardar las maximas repeticiones

        for(int i = 0; i < 10; i++)
        {            
            int repeticionesActual = 0;
            //Comparamos el numero actual por todos los de la tabla
            for(int j = 0; j < 10; j++)
            {
                //Si coinciden, suma una repeticion
                if(numeros[i] == numeros[j])
                {
                    repeticionesActual++;
                }
            }
            //Si las repeticiones actuales son mayores a las max, ese numero es la moda
            //La primera vez lo compara con 0
            if(repeticionesActual > repeticionesMax)
            {
                repeticionesMax = repeticionesActual;
                moda = numeros[i];
                
            }

        }
        Console.Write("El conjunto de números introducido: ");
        foreach(double num in numeros)
        {
            Console.Write(num+" ");
        }
        Console.WriteLine(); //Salto línea
        Console.WriteLine("La MEDIA de este conjunto es: "+media);
        Console.WriteLine("Su MODA: "+moda);
        Console.Write("Los números que son menores de la media: ");

        foreach(double num in numeros)
        {
            if (num < media)
            {
                Console.Write(num+" ");
            }
        }
    }
}