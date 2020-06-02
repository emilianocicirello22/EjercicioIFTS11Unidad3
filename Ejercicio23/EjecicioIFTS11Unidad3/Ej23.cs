using System;
//23) Se necesita crear un programa que imprima lotes de 100 tiquets. La numeración de los tiquets tiene que tener 
// saltos de 10 en diez.  Utilizando el ciclo de repetición Mientras – Hacer.

namespace EjecicioIFTS11Unidad3
{
    class Ej23
    {
        static void Main(string[] args)
        {
            //declaramos variables
            int cont = 0;

            //imprimimos los ticket
            while (cont < 1000)
            {
                //incrementamos el contador para que salte de 10 en 10
                cont += 10;
                //imprimimos el ticket
                Console.WriteLine($"numero de ticket {cont}");
            }
        }
    }
}
