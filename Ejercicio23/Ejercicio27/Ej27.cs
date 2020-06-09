using System;
//27. Informar las potencias de 2 a partir de 2^0   y como máximo 2^10 

namespace Ejercicio27
{
    class Ej27
    {
        static void Main(string[] args)
        {
            //inicializamos variables
            double potencia = 0;
            
            for(int i =0; i<=10; i++)
            {
                Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
            }
        }
    }
}
