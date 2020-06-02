using System;
//24. Se necesita crear un programa que imprima lotes de 100 tiquets. La numeración de los tiquets tiene que tener 
//saltos de 10 en diez.  Utilizando el ciclo de repetición Hacer – Mientras.

namespace Ejercicio24
{
    class Ej24
    {
        static void Main(string[] args)
        {
            //inicializamos variables 
            int cont = 0;

            //imprimimos tickets
            do
            {
                //incrementamos el contador de 10 en 10
                cont += 10;
                Console.WriteLine($"ticket numero: {cont}");

            } while (cont < 1000);

        }
    }
}
